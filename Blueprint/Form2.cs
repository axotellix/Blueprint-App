using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Blueprint.Components;
using Blueprint.Components.Tabs;
using Blueprint.Utils.UI;

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
    }
}
