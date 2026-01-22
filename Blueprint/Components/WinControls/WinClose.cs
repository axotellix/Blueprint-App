using Blueprint.Utils.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blueprint.Components.WinControls
{
    [ToolboxItem(true)]
    public partial class WinClose : RoundedComponent
    {
        public WinClose()
        {
            InitializeComponent();
        }

        private void WinClose_Load(object sender, EventArgs e)
        {
            // set > Component style
            this.BackColor = GlassUIColors.GreyDark;

            // register > events
            Icon.MouseEnter += Icon_Hover;
            Icon.MouseLeave += Icon_HoverOut;
            Icon.Click += Icon_Click;
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            Form win = this.FindForm();
            win.Close();
        }

        private void Icon_Hover(object sender, EventArgs e)
        {
            this.BackColor = GlassUIColors.GreyDark.Lighten(10);
        }

        private void Icon_HoverOut(object sender, EventArgs e)
        {
            this.BackColor = GlassUIColors.GreyDark;
        }
    }
}
