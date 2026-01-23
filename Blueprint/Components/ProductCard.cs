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

            this.MouseEnter += Card_Hover;
            ProductPicture.MouseEnter += Card_Hover;
            BtnEdit.MouseEnter += Card_Hover;

            this.MouseLeave += Card_HoverOut;
            ProductPicture.MouseLeave += Card_HoverOut;
            BtnEdit.MouseLeave += Card_HoverOut;
            
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

        private void Card_Hover(object sender, EventArgs e)
        {
            this.BackColor = GlassUIColors.GreyCard.Lighten(2);
            this.BorderColor = GlassUIColors.GreyBorderLight.Lighten(2);
        }
        private void Card_HoverOut(object sender, EventArgs e)
        {
            this.BackColor = GlassUIColors.GreyCard;
            this.BorderColor = GlassUIColors.GreyBorderLight;
        }
    }

}
