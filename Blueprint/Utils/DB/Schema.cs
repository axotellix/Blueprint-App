using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Blueprint.Utils.DB {
    
    // 
    public static class Schema {

        //@ set > active table
        public static _Schema Table(String t)
        {
            return new _Schema(t);
        }

    }

    public class _Schema {

        // [ PRESETS ]
        private SqlConnection conn = null;                  // keep > connection
        private String query;                               // keep > SQL query
        private String table;                               // keep > DB table
        private List<String> fields = new List<String>();   // keep > selected fields

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
            conn.Close();
        }


        // [ METHODS ]
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
            query = $"SELECT {String.Join(", ", fields)} FROM {table}";
            return this;
        }

        //@ filter > selection
        public _Schema Where( String field, String expr, object value )
        {
            query += $" WHERE {field} {expr} {value}";
            return this;
        }

        //@ run > select command
        public SqlDataReader Get()
        {
            // open > connection to DB
            this.OpenConn();

            // run > SQL query
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // return > result
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
    }
}
