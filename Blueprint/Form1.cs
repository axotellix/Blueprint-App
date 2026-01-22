/* ---- [ IMPORTS ] ---- */

// import > GlassUI UI Library
using Blueprint.Components;
using Blueprint.Utils.UI;


/* ---- [ MAIN ] ---- */
namespace Blueprint
{
    public partial class Form1 : GlassUIForm
    {
        public Form1()
        {
            // set up > Form style
            this.BackColor = GlassUIColors.Dark;
            this.FormOpacity = 220;
            this.EFFECT = ACCENT_ENABLE_BLURBEHIND;

            InitializeComponent();
            MainContainer.BorderColor = GlassUIColors.GreyBorder;

            // get > active tab (when swicthed)
            SidebarMain.TabSwitched += SwitchTab;
        }

        // handle > TabSwitched event (from Sidebar)
        private void SwitchTab(object sender, int TabIndex)
        {
            Tab.Text = Convert.ToString(TabIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(this.BackColor));
        }
    }
}
