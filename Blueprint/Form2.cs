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
            var products = Schema.Table("Products").All();
            while (products.Read())
            {
                ProductCard c = new ProductCard();
                c.ProductNameText = Convert.ToString(products["product_name"]);
                c.Price = "₽ " + Convert.ToString(products["price"]);
                FlowContainer.Controls.Add(c);
            }
        }
    }
}
