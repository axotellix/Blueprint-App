/* ---- [ IMPORTS ] ---- */

// import > GlassUI UI Library
using Blueprint.Components;
using Blueprint.Components.Tabs;
using Blueprint.Utils.UI;


/* ---- [ MAIN ] ---- */
namespace Blueprint
{
    public partial class Form1 : GlassUIForm {
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
            // clear > prev Tab content
            MainContainer.Controls.Clear();

            // set > new Tab
            UserControl tab;
            switch (TabIndex) {
                case 1:
                    tab = new TabProducts();
                    break;
                case 2:
                    tab = new TabCreateProduct();
                    break;
                case 3:
                    tab = new TabOrders();
                    break;
                case 4:
                    tab = new TabClients();
                    break;
                default:
                    tab = new TabProducts();
                    break;
            }

            // switch > new Tab content
            MainContainer.Controls.Add(tab);
            tab.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SwitchTab(sender, 1);
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
