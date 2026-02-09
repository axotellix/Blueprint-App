using Blueprint.Utils.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blueprint.Components.Tabs {

    [ToolboxItem(false)]
    public partial class TabCreateProduct : UserControl {
        public TabCreateProduct()
        {
            InitializeComponent();
        }

        public void btn_Create_Click(object sender, EventArgs e)
        {
            // check > if valid data entered
            bool form_valid = true;

            // prepare > data for upload
            String product_img = null;
            String product_name = null;
            int? product_price = null;

            // clear > previous error messages
            input_ProductName.ErrMsgText = "";

            // read > product name
            try {

                // get > product name value
                String name = input_ProductName.Val().Trim();

                // check > if empty
                if (name == null || name == "") {

                    input_ProductName.ErrMsgText = "введите непустое значение";
                    form_valid = false;

                } else {

                    // save > product name
                    product_name = name;

                }

            } catch (Exception ex) {
                MessageBox.Show("Возникла ошибка при попытке считать имя товара");
            }

            // read > product price
            try {

                // get > product price value
                String price = input_ProductPrice.Val().Trim();

                // check > if empty
                if (price == null || price == "") {

                    input_ProductPrice.ErrMsgText = "введите непустое значение";
                    form_valid = false;

                } else {

                    // check > if NaN | save > product price
                    product_price = Convert.ToInt32(price);

                }

            } catch (Exception ex) {
                MessageBox.Show("Возникла ошибка при попытке считать цены товара. Возможно вы ввели не число.");
            }

            // read > product image
            try {

                // get > product image value
                String img = input_ProductImage.FilePath;

                // check > if empty
                if (img == null || img == "")
                {
                    ErrImg_ImgPicker.Visible = true;
                    ErrMsg_ImgPicker.Visible = true;
                    ErrMsg_ImgPicker.Text = "Пожалуйста, загрузите фото товара";
                    form_valid = false;
                }

                // save > product img
                product_img = img;

            } catch (Exception ex) {
                MessageBox.Show("Возникла ошибка при попытке загрузить фото товара");
            }
            
            // save > product to DB 
            if (form_valid) {

                var product = new Dictionary<string, object>
                {
                    { "product_name", product_name },
                    { "price", product_price },
                    { "img_path", product_img }
                };

                Schema.Table("Products").Add(product);
                MessageBox.Show("Товар успешно создан");

            }
        }

        private void input_ProductImage_Click(object sender, EventArgs e)
        {
            // clear > error message
            ErrImg_ImgPicker.Visible = false;
            ErrMsg_ImgPicker.Visible = false;
            ErrMsg_ImgPicker.Text = "";
        }
    }

}
