using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Blueprint.Utils.DB {
    
    //: entry point to main class (_Schema)
    public static class Schema {

        //@ set > active table
        public static _Schema Table(String t)
        {
            return new _Schema(t);
        }

        //@ set > SQL() method adapter (to use in entry point)
        public static _Schema SQL( String q )
        {
            return new _Schema("").SQL(q);
        }
    }

    //: main class
    public class _Schema {

        // [ PRESETS ]
        private SqlConnection conn = null;                  // keep > connection
        private String query;                               // keep > SQL query
        private String table;                               // keep > DB table
        private String filter = "";                         // keep > WHERE clause
        private List<String> fields = new List<String>();   // keep > selected fields
        private List<SqlParameter> parameters = new List<SqlParameter>();   // keep > SQL query params

        public _Schema(String t)
        {
            this.table = t;
        }


        // [ HELPERS ]
        //@ open > DB connection
        private void OpenConn()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BlueprintDB"].ConnectionString);
            conn.Open();
        }

        //@ close > DB connection
        private void CloseConn()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }


        // [ METHODS ]
        //@ write > direct SQL query
        public _Schema SQL( String q )
        {
            // clear > params
            parameters.Clear();

            // write > new SQL query
            query = q;

            // return > static instance (for methods chaining)
            return this;
        }

        //@ bind > SQL query params
        public _Schema Params(String key, object value)
        {
            // process > NULL values
            object val = value ?? DBNull.Value;

            // store > params in params list
            parameters.Add(new SqlParameter(key, val));

            // return > static instance (for methods chaining)
            return this;
        }
         // overload > Params (bind multiple params by dictionary)
        public _Schema Params(Dictionary<string, object> paramsList)
        {
            foreach (var item in paramsList)
            {
                // reuse > single param binding method
                this.Params(item.Key, item.Value);
            }
            return this;
        }

        //@ run > direct SQL query
        public T Run<T>()
        {
            // open > connection to DB
            this.OpenConn();

            // run > SQL query
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // build-in > params to SQL query
                if (parameters.Count > 0) {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                //: SELECT queries
                if (typeof(T) == typeof(SqlDataReader)) {

                    return (T)(object)cmd.ExecuteReader(CommandBehavior.CloseConnection);

                }
                 //: INSERT / UPDATE / DELETE queries
                else if (typeof(T) == typeof(int)) {

                    int result = cmd.ExecuteNonQuery();
                    this.CloseConn();
                    return (T)(object)result;

                }
                 // SCALAR query (SELECT COUNT, SELECT Column, etc.)
                else {

                    object result = cmd.ExecuteScalar();
                    this.CloseConn();

                    if (result == null || result == DBNull.Value)
                        return default(T);

                    return (T)Convert.ChangeType(result, typeof(T));

                }
            }
        }
        //@ get > records (by Run command)
        public SqlDataReader Records()
        {
            return this.Run<SqlDataReader>();
        }
        //@ get > number of records affected (by Run command)
        public int Number()
        {
            return this.Run<int>();
        }
        //@ get > nothing (by Run command) 
        public void Done()
        {
            this.Run<int>();
        }

        //@ get > all records
        public SqlDataReader All()
        {
            // open > connection to DB
            this.OpenConn();

            // build > SQL query
            query = $"SELECT * FROM {table}";

            // run > SQL query
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // return > result
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }

        }

        //@ select > specific fields
        public _Schema Select( params String[] _fields )
        {
            fields.Clear();
            fields.AddRange(_fields);
            return this;
        }

        //@ filter > selection
        public _Schema Where( String field, String expr, object value )
        {
            // add > correct SQL keyword (if WHERE already exists - add another filter)
            String prefix = (filter == "") ? "WHERE" : "AND";

            // wrap > string in quotation marks
            if (value is string) {
                value = $"'{value}'";
            }

            // add > filter to SQL query
            filter += $" {prefix} {field} {expr} {value}";
            return this;
        }

        //@ run > select command
        public SqlDataReader Get()
        {
            // open > connection to DB
            this.OpenConn();

            // set > columns
            String cols = (fields.Count > 0) ? String.Join(", ", fields) : "*";

            // build > SQL query
            query = $"SELECT {cols} FROM {table} {filter}";

            // run > SQL query
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // return > result
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        //@ add > new record
        public int Add(Dictionary<string, object> data)
        {
            // open > connection to DB
            this.OpenConn();

            // get > columns string
            String columns = String.Join(", ", data.Keys);

            // set > values wildcards string
            List<String> valuesWildcards = new List<String>();
            for (int i = 0; i < data.Count; i++) valuesWildcards.Add($"@val{i}");
            String values = String.Join(", ", valuesWildcards);

            // build > SQL query template
            query = $"INSERT INTO {table} ({columns}) VALUES ({values})";

            // build & run > SQL query
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // fill > SQL query template
                int i = 0;
                foreach (var col in data) {
                    // process > NULL values (set NULL explicitly if empty)
                    object val = col.Value ?? DBNull.Value;

                    // fill > wildcards (VALUES)
                    cmd.Parameters.AddWithValue($"@val{i}", val);
                    i++;
                }

                // run > query
                int result = cmd.ExecuteNonQuery();
                this.CloseConn();

                // return > number of rows added
                return result; 
            }
        }

        //@ update > record (by dictionary)
        public int Set(Dictionary<string, object> data)
        {
            // open > connection to DB
            this.OpenConn();

            // set > edit pairs wildcards string
            String editPairs = "";
            int i = 0;
            foreach (var key in data.Keys)
            {
                editPairs += $"{key} = @val{i}";
                i++;
            }

            // build > SQL query template
            query = $"UPDATE {table} SET {editPairs} {filter}";

            // build & run > SQL query
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // fill > SQL query template
                int j = 0;
                foreach (var col in data) {
                    // process > NULL values (set NULL explicitly if empty)
                    object val = col.Value ?? DBNull.Value;

                    // fill > wildcards (SET)
                    cmd.Parameters.AddWithValue($"@val{j}", val);
                    j++;
                }

                // run > query
                int result = cmd.ExecuteNonQuery();
                this.CloseConn();

                // return > number of rows updated
                return result; 
            }
        }

        //@ update > record (by string params)
        public int Set( params string[] edit )
        {
            // open > connection to DB
            this.OpenConn();

            // build > SQL query
            query = $"UPDATE {table} SET {String.Join(", ", edit)} {filter}";

            // build & run > SQL query
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // run > query
                int result = cmd.ExecuteNonQuery();
                this.CloseConn();

                // return > number of rows updated
                return result; 
            }
        }

        //@ delete > record
        public int Delete()
        {
            // open > connection to DB
            this.OpenConn();

            //? if > filter applied (otherwise - whole table will be emptied)
            if (filter == "") {
                throw new Exception("Не указана запись, которую нужно удалить");
            } else {
                query = $"DELETE FROM {table} {filter}";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int result = cmd.ExecuteNonQuery();
                    this.CloseConn();
                    return result;
                }
            }    
        }

    }
}
