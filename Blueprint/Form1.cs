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
            this.BackColor = Color.Black;
            this.FormOpacity = 120;
            this.EFFECT = ACCENT_ENABLE_ACRYLICBLURBEHIND;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
