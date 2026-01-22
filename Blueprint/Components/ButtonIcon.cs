using AcrylicUI.Resources;
using Blueprint.Utils.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blueprint.Components
{
    public partial class ButtonIcon : RoundedComponent
    {
        // set > Component props
        private Image icon;

         // Prop: Icon (image)
        [Category("Appearance")]
        [Description("Иконка кнопки")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Icon
        {
            get => icon;
            set
            {
                icon = value;
                SetIcon();
            }
        }

        private void SetIcon() {
            if( icon != null ) {
                IconBox.Image = icon;
            }
        }



        // keep > Component state
        private Color BackColor_default;

        public ButtonIcon()
        {
            InitializeComponent();
            BackColor_default = this.BackColor;
        }

        private void Button_Load(object sender, EventArgs e)
        {
            // register > events
            this.MouseEnter += Button_Hover;
            this.MouseLeave += Button_HoverOut;
        }

        private void Button_Hover(object sender, EventArgs e)
        {
            this.BackColor = BackColor_default.Lighten(40);
        }

        private void Button_HoverOut(object sender, EventArgs e)
        {
            this.BackColor = BackColor_default;
        }
    }
}
