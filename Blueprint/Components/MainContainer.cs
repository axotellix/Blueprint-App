using Blueprint.Utils.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Blueprint.Components
{
    public partial class MainContainer : RoundedComponent
    {
        public MainContainer()
        {
            InitializeComponent();
            this.BackColor = GlassUIColors.GreyDark;
        }
    }
}
