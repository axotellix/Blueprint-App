using AcrylicUI.Resources;
using Blueprint.Utils.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Blueprint.Components {
    
    [ToolboxItem(true)]
    public partial class Button : RoundedComponent {
        /* ---- [ PRESETS ] ---- */

        // button styles
        public enum Styles {
            Normal = 1,
            Light = 2
        }

        // hover & press effect influence
        private const int HOVER_INFLUENCE = 7;
        private const int PRESS_INFLUENCE = 4;



        /* ---- [ COMPONENT ] ---- */

        // [ set > Component props ]
        private Size size;                      //: keep Component init size
        private String text = "button";
        private Font font = new Font("NT Somic", 10f);
        private Styles style = Styles.Normal;
        private Color BackColor_default;        //: keep Component state
        private Color BorderColor_default;      //: keep Component state

        //# Prop: Size
        [Category("Appearance")]
        [Description("Размер кнопки")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Size ButtonSize
        {
            get => size;
            set
            {
                size = value;
                SetStyle();
            }
        }

        //# Prop: Text
        [Category("Appearance")]
        [Description("Текст кнопки")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public String TextContent
        {
            get => text;
            set
            {
                text = value;
                SetStyle();
            }
        }

        //# Prop: Font
        [Category("Appearance")]
        [Description("Шрифт кнопки")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font Font
        {
            get => font;
            set
            {
                font = value;
                SetStyle();
            }
        }

        //# Prop: Button Style
        [Category("Appearance")]
        [Description("Стиль")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Styles Style
        {
            get => style;
            set
            {
                style = value;
                SetStyle();
            }
        }


        //@ helper > set button style (icon, appearance)
        private void SetStyle()
        {
            switch (style)
            {

                // normal style (background + border)
                case Styles.Normal:
                    this.Size           = size;
                    Label.Text          = text;
                    Label.Font          = font;
                    this.BorderColor    = GlassUIColors.GreyBorder;
                    this.BackColor      = GlassUIColors.GreyDark;
                    this.BorderWidth    = 1;
                    BackColor_default   = this.BackColor;
                    BorderColor_default = this.BorderColor;
                    this.ForeColor      = GlassUIColors.White;
                    break;

                // inactive style (no background & border)
                case Styles.Light:
                    this.Size           = size;
                    Label.Text          = text;
                    Label.Font          = font;
                    this.BorderColor    = GlassUIColors.GreyBorderExtraLight;
                    this.BackColor      = GlassUIColors.GreyCardLight;
                    this.BorderWidth    = 1;
                    BackColor_default   = this.BackColor;
                    BorderColor_default = this.BorderColor;
                    this.ForeColor      = GlassUIColors.White;
                    break;

                // default style (normal)
                default:
                    this.Size           = size;
                    Label.Text          = text;
                    Label.Font          = font;
                    this.BorderColor    = GlassUIColors.GreyBorder;
                    this.BackColor      = GlassUIColors.GreyDark;
                    this.BorderWidth    = 1;
                    BackColor_default   = this.BackColor;
                    BorderColor_default = this.BorderColor;
                    this.ForeColor      = GlassUIColors.White;
                    break;

            }
        }

        //@ helper > set button style (icon, appearance)
        private void SetStyleHover(object sender, EventArgs e)
        {
            this.BackColor = BackColor_default.Lighten(HOVER_INFLUENCE);
            this.BorderColor = BorderColor_default.Lighten(HOVER_INFLUENCE);
        }

        //@ helper > set button style (icon, appearance)
        private void SetStyleHoverOut(object sender, EventArgs e)
        {
            this.BackColor = BackColor_default;
            this.BorderColor = BorderColor_default;
        }

        //@ helper > set button style (icon, appearance)
        private void SetStylePress(object sender, EventArgs e)
        {
            this.BackColor = BackColor_default.Lighten(PRESS_INFLUENCE);
            this.BorderColor = BorderColor_default.Lighten(PRESS_INFLUENCE);
        }

        //@ helper > set button style (icon, appearance)
        private void SetStylePressOut(object sender, EventArgs e)
        {
            this.BackColor = BackColor_default.Lighten(HOVER_INFLUENCE);
            this.BorderColor = BorderColor_default.Lighten(HOVER_INFLUENCE);
        }


        // [ init > component ]
        public Button()
        {
            InitializeComponent();
            this.Load += Button_Load;
        }


        // [ set > events ]
        private void Button_Load(object sender, EventArgs e)
        {
            // register > events
            this.MouseEnter += SetStyleHover;
            Label.MouseEnter += SetStyleHover;

            this.MouseLeave += SetStyleHoverOut;
            Label.MouseLeave += SetStyleHoverOut;

            this.MouseDown += SetStylePress;
            Label.MouseDown += SetStylePress;

            this.MouseUp += SetStylePressOut;
            Label.MouseUp += SetStylePressOut;

            // set > component style
            SetStyle();
        }

    }
}
