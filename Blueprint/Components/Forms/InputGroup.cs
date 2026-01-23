using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blueprint.Components.Forms {
    public partial class InputGroup : UserControl {

        /* ---- [ COMPONENT ] ---- */

        // [ set > Component props ]
        private String label;
        private String placeholder;
        private String err_msg;

        //# Prop: Label
        [Category("Appearance")]
        [Description("Label")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public String LabelText
        {
            get => label;
            set
            {
                label = value;
                InputLabel.Text = value;
            }
        }

        //# Prop: Placeholder
        [Category("Appearance")]
        [Description("Placeholder")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public String Placeholder
        {
            get => placeholder;
            set
            {
                placeholder = value;
                InputTextbox.Placeholder = value;
            }
        }

        //# Prop: Error Message
        [Category("Appearance")]
        [Description("Err Message")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public String ErrMsgText
        {
            get => err_msg;
            set
            {
                err_msg = value;

                // hide > if empty
                if (value == "")
                {
                    ErrMsg.Text = "";
                    ErrImg.Visible = false;
                }
                else
                {
                    ErrMsg.Text = value;
                    ErrImg.Visible = true;
                }
            }
        }

        public InputGroup()
        {
            InitializeComponent();
        }

        private void InputGroup_Load(object sender, EventArgs e)
        {
            ErrImg.Visible = false;
        }
    }
}
