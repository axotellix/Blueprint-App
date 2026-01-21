/* ---- [ IMPORTS ] ---- */

// import > GlassUI UI Library
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
            this.FormOpacity = 200;
            this.EFFECT = ACCENT_ENABLE_BLURBEHIND;

            InitializeComponent();
            MainContainer.BorderColor = GlassUIColors.GreyBorder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
