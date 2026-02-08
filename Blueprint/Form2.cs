using Blueprint.Components;
using Blueprint.Components.Tabs;
using Blueprint.Utils.DB;
using Blueprint.Utils.UI;
using Fizzler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blueprint {
    public partial class Form2 : GlassUIForm {
        public Form2()
        {

            // set up > Form style
            this.BackColor = GlassUIColors.Dark;
            this.FormOpacity = 220;
            this.EFFECT = ACCENT_ENABLE_BLURBEHIND;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Schema.Table("Products").Where("product_name", "=", "new product").Set(
                    "product_name = 'upd product'",    
                    "price = 1100"    
                );

            //var products = Schema.Table("Products").All();
            var products = Schema.Table("Products").Select("*").Where("price", ">", 400).Get();
            while (products.Read())
            {
                ProductCard c = new ProductCard();
                c.ProductNameText = str(products["product_name"]);
                c.Price = "₽ " + str(products["price"]);
                FlowContainer.Controls.Add(c);
            }
        }
    }
}
