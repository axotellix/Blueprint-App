using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blueprint.Components
{
    [ToolboxItem(true)]
    public partial class Sidebar : UserControl {

        private ButtonIcon active_button;

        public Sidebar()
        {
            InitializeComponent();
            active_button = Nav_Products;
        }

        //@ set > active nav item
        private void SetActiveButton(ButtonIcon clickedButton)
        {
            // reset > current active
            if (active_button != null) {
                active_button.Style = (ButtonIcon.Styles)ButtonIcon.Styles.Inactive;
            }

            // set > new active
            clickedButton.Style = (ButtonIcon.Styles)ButtonIcon.Styles.Normal;
            active_button = clickedButton;
        }

        private void Nav_Products_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as ButtonIcon);
        }

        private void Nav_Create_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as ButtonIcon);
        }

        private void Nav_Orders_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as ButtonIcon);
        }

        private void Nav_Clients_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as ButtonIcon);
        }
    }
}
