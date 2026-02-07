using AcrylicUI.Controls;
using Blueprint.Utils.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Blueprint.Components.Tabs {
    public partial class TabProducts : UserControl {

        private int top;
        private SqlConnection conn = null;

        [ToolboxItem(false)]
        public TabProducts()
        {
            InitializeComponent();
        }

        private int getProductsAmount()
        {
            int totalCount = 0;

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BlueprintDB"].ConnectionString);
            conn.Open();

            string query = "SELECT dbo.fn_GetTotalProductsCount()";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                totalCount = Convert.ToInt32(cmd.ExecuteScalar());
            }

            conn.Close();
            return totalCount;
        }

        private void TabProducts_Load(object sender, EventArgs e)
        {
            top = FlowContainer.Top;
            FlowContainer.AutoScroll = false;
            ScrollBarCustom.BackColor = GlassUIColors.GreyDark;
            SetupScrollBar();

            Lable_ProductsAmount.Text = "Всего: " + Convert.ToString(getProductsAmount()) + " шт.";

            //[DB] get > product cards

            FlowContainer.Controls.Clear();

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BlueprintDB"].ConnectionString);
            conn.Open();

            SqlDataReader reader;
            try
            {
                SqlCommand cmd = new SqlCommand(@"
                                        SELECT product_id, product_name, price, img_path 
                                        FROM Products", conn);
                reader = cmd.ExecuteReader();

                //: while have rows 
                while (reader.Read())
                {
                    ProductCard c = new ProductCard();
                    c.ProductNameText = Convert.ToString(reader["product_name"]);
                    c.Price = "₽ " + Convert.ToString(reader["price"]);
                    FlowContainer.Controls.Add(c);
                }

                if (reader != null && !reader.IsClosed) reader.Close();
            }
            catch (Exception ex)
            {
                //...
            }
            finally
            {
                //: need to close reader mannually
                //if (reader != null && !reader.IsClosed) reader.Close();
                conn.Close();
            }

            //[/DB] get > product cards
        }

        private void acrylicScrollBar1_ValueChanged(object sender, AcrylicUI.Controls.ScrollValueEventArgs e)
        {

            // Отключаем перерисовку для избежания мерцания
            FlowContainer.SuspendLayout();

            // Прокрутка
            FlowContainer.VerticalScroll.Value = Math.Clamp(
                ScrollBarCustom.Value,
                FlowContainer.VerticalScroll.Minimum,
                FlowContainer.VerticalScroll.Maximum
            );

            // Скрываем стандартный скролл (ДО ResumeLayout)
            //flowLayoutPanel1.VerticalScroll.Visible = false;

            // Возобновляем перерисовку
            FlowContainer.ResumeLayout(false);
        }

        private void SetupScrollBar()
        {
            // 3. Вычислить видимую высоту
            int visibleHeight = FlowContainer.ClientSize.Height;

            // 4. Настроить скроллбар
            ScrollBarCustom.Minimum = 0;
            ScrollBarCustom.Maximum = visibleHeight;
            ScrollBarCustom.ViewSize = (int)Math.Ceiling(visibleHeight / 4.0);
        }

        private void acrylicScrollBar1_MouseUp(object sender, MouseEventArgs e)
        {
            FlowContainer.AutoScroll = false;
            FlowContainer.VerticalScroll.Value = Math.Clamp(
                ScrollBarCustom.Value,
                FlowContainer.VerticalScroll.Minimum,
                FlowContainer.VerticalScroll.Maximum
            );
        }
    }

}
