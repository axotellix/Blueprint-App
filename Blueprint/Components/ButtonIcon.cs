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

namespace Blueprint.Components
{
    [ToolboxItem(true)]
    public partial class ButtonIcon : RoundedComponent
    {
        /* ---- [ PRESETS ] ---- */

         // button styles
        public enum Styles {
            Normal = 1,
            Inactive = 2
        }

         // hover & press effect influence
        private const int HOVER_INFLUENCE = 7;
        private const int PRESS_INFLUENCE = 4;



        /* ---- [ COMPONENT ] ---- */

        // [ set > Component props ]
        private String text = "button";
        private Font font = new Font("NT Somic", 10f);
        private Image icon;
        private Image icon_inactive;
        private Styles style = Styles.Normal;
        private Color BackColor_default;        //: keep Component state
        private Color BorderColor_default;      //: keep Component state

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

         //# Prop: Icon (image)
        [Category("Appearance")]
        [Description("Иконка кнопки")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Icon
        {
            get => icon;
            set
            {
                icon = value;
                SetStyle();
            }
        }

         //# Prop: Icon Inactive (image)
        [Category("Appearance")]
        [Description("Иконка неактивной кнопки")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image IconInactive
        {
            get => icon_inactive;
            set
            {
                icon_inactive = value;
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
        private void SetStyle() {
            switch( style ) {

                // normal style (background + border)
                case Styles.Normal:
                    Label.Text = text;
                    Label.Font = font;
                    this.BorderColor = GlassUIColors.GreyBorder;
                    this.BackColor = GlassUIColors.GreyDark;
                    this.BorderWidth = 1;
                    BackColor_default = this.BackColor;
                    BorderColor_default = this.BorderColor;
                    this.ForeColor = GlassUIColors.White;
                    if (icon != null) {
                        IconBox.Image = icon;
                    }
                    break;

                // inactive style (no background & border)
                case Styles.Inactive:
                    Label.Text = text;
                    Label.Font = font;
                    this.BorderColor = Color.Transparent;
                    this.BackColor = Color.Transparent;
                    this.BorderWidth = 0;
                    BackColor_default = this.BackColor;
                    BorderColor_default = this.BorderColor;
                    this.ForeColor = GlassUIColors.Grey;
                    if (icon_inactive != null)
                    {
                        IconBox.Image = icon_inactive;
                    }
                    break;

                // default style (normal)
                default:
                    Label.Text = text;
                    Label.Font = font;
                    this.BorderColor = GlassUIColors.GreyBorder;
                    this.BackColor = GlassUIColors.GreyDark;
                    this.BorderWidth = 1;
                    BackColor_default = this.BackColor;
                    BorderColor_default = this.BorderColor;
                    this.ForeColor = GlassUIColors.White;
                    if (icon != null)
                    {
                        IconBox.Image = icon;
                    }
                    break;

            }
        }

         //@ helper > set button style (icon, appearance)
        private void SetStyleHover( object sender, EventArgs e )
        {
            switch (style)
            {

                // normal style (background + border)
                case Styles.Normal:
                    this.BackColor = BackColor_default.Lighten(HOVER_INFLUENCE);
                    this.BorderColor = BorderColor_default.Lighten(HOVER_INFLUENCE);
                    break;

                // inactive style (no background & border)
                case Styles.Inactive:
                    this.BackColor = Color.FromArgb(HOVER_INFLUENCE, 247, 250, 255);
                    this.BorderColor = Color.FromArgb(15 + HOVER_INFLUENCE, 247, 250, 255);
                    break;

                // default style (normal)
                default:
                    this.BackColor = BackColor_default.Lighten(HOVER_INFLUENCE);
                    this.BorderColor = BorderColor_default.Lighten(HOVER_INFLUENCE);
                    break;

            }
        }

         //@ helper > set button style (icon, appearance)
        private void SetStyleHoverOut( object sender, EventArgs e )
        {
            switch (style)
            {

                // normal style (background + border)
                case Styles.Normal:
                    this.BackColor = BackColor_default;
                    this.BorderColor = BorderColor_default;
                    break;

                // inactive style (no background & border)
                case Styles.Inactive:
                    this.BackColor = Color.Transparent;
                    this.BorderColor = Color.Transparent;
                    break;

                // default style (normal)
                default:
                    this.BackColor = BackColor_default;
                    this.BorderColor = BorderColor_default;
                    break;

            }
        }

         //@ helper > set button style (icon, appearance)
        private void SetStylePress( object sender, EventArgs e )
        {
            switch (style)
            {

                // normal style (background + border)
                case Styles.Normal:
                    this.BackColor = BackColor_default.Lighten(PRESS_INFLUENCE);
                    this.BorderColor = BorderColor_default.Lighten(PRESS_INFLUENCE);
                    break;

                // inactive style (no background & border)
                case Styles.Inactive:
                    this.BackColor = Color.FromArgb(PRESS_INFLUENCE, 247, 250, 255);
                    this.BorderColor = Color.FromArgb(15 + PRESS_INFLUENCE, 247, 250, 255);
                    break;

                // default style (normal)
                default:
                    this.BackColor = BackColor_default.Lighten(PRESS_INFLUENCE);
                    this.BorderColor = BorderColor_default.Lighten(PRESS_INFLUENCE);
                    break;

            }
        }

         //@ helper > set button style (icon, appearance)
        private void SetStylePressOut( object sender, EventArgs e )
        {
            switch (style)
            {

                // normal style (background + border)
                case Styles.Normal:
                    this.BackColor = BackColor_default.Lighten(HOVER_INFLUENCE);
                    this.BorderColor = BorderColor_default.Lighten(HOVER_INFLUENCE);
                    break;

                // inactive style (no background & border)
                case Styles.Inactive:
                    this.BackColor = Color.FromArgb(HOVER_INFLUENCE, 247, 250, 255);
                    this.BorderColor = Color.FromArgb(15 + HOVER_INFLUENCE, 247, 250, 255);
                    break;

                // default style (normal)
                default:
                    this.BackColor = BackColor_default.Lighten(HOVER_INFLUENCE);
                    this.BorderColor = BorderColor_default.Lighten(HOVER_INFLUENCE);
                    break;

            }
        }


        // [ init > component ]
        public ButtonIcon()
        {
            InitializeComponent();
        }


        // [ set > events ]
        private void Button_Load(object sender, EventArgs e)
        {
            // register > events
            this.MouseEnter += SetStyleHover;
            IconBox.MouseEnter += SetStyleHover;
            Label.MouseEnter += SetStyleHover;

            this.MouseLeave += SetStyleHoverOut;
            IconBox.MouseLeave += SetStyleHoverOut;
            Label.MouseLeave += SetStyleHoverOut;

            this.MouseDown += SetStylePress;
            IconBox.MouseDown += SetStylePress;
            Label.MouseDown += SetStylePress;

            this.MouseUp += SetStylePressOut;
            IconBox.MouseUp += SetStylePressOut;
            Label.MouseUp += SetStylePressOut;


            // set > component style
            SetStyle();
        }

    }
}
