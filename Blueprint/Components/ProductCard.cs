using Blueprint.Utils.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blueprint.Components {

    [ToolboxItem(true)]
    public partial class ProductCard : RoundedComponent {
        public ProductCard()
        {
            InitializeComponent();
            
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {
            // set > Component style
            this.BackColor = GlassUIColors.GreyCard;
            this.BorderColor = GlassUIColors.GreyBorderLight;
            this.Size = new Size(260, 310); 

            // set > picture box size & location
            ProductPicture.Size = new Size(234, 150);
            ProductPicture.Location = new Point(13, 13);

            // set > button size & location
            BtnEdit.Size = new Size(234, 46);
            BtnEdit.Location = new Point(13, 251);
        }
    }

}
