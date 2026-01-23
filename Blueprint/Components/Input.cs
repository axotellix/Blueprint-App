using Blueprint.Utils.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Blueprint.Components {
    public partial class Input : UserControl {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TextValue
        {
            get => InputTextbox.Text;
            set => InputTextbox.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Placeholder
        {
            get => InputTextbox.PlaceholderText;
            set => InputTextbox.PlaceholderText = value;
        }

        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {
            InputTextbox.BorderStyle = BorderStyle.None;
            InputTextbox.Size = InputBackground.Size;

            Placeholder = InputTextbox.PlaceholderText;
        }

        // on > focus
        private void InputTextbox_Enter(object sender, EventArgs e)
        {
            InputBackground.BorderColor = GlassUIColors.GreyBorder.Lighten(10);
        }

        private void InputTextbox_Leave(object sender, EventArgs e)
        {
            InputBackground.BorderColor = GlassUIColors.GreyBorder;
        }

        private void InputTextbox_Layout(object sender, LayoutEventArgs e)
        {
            InputTextbox.BorderStyle = BorderStyle.None;
            InputTextbox.Size = InputBackground.Size; ;
        }

        private void InputTextbox_TextChanged(object sender, EventArgs e)
        {
            TextValue = InputTextbox.Text;
        }
    }
}
