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
    public partial class PanelRound : RoundedPanel {
        public PanelRound()
        {
            InitializeComponent();
            this.BackColor = GlassUIColors.GreyDark;
            this.BorderColor = GlassUIColors.GreyBorder;
        }
    }
}
