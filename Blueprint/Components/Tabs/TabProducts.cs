using AcrylicUI.Controls;
using Blueprint.Utils.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Blueprint.Components.Tabs {
    public partial class TabProducts : UserControl {

        private int top;

        [ToolboxItem(false)]
        public TabProducts()
        {
            InitializeComponent();
        }

        private void TabProducts_Load(object sender, EventArgs e)
        {
            top = FlowContainer.Top;
            FlowContainer.AutoScroll = false;
            ScrollBarCustom.BackColor = GlassUIColors.GreyDark;
            SetupScrollBar();
        }

        private void acrylicScrollBar1_ValueChanged(object sender, AcrylicUI.Controls.ScrollValueEventArgs e)
        {

            // Отключаем перерисовку для избежания мерцания
            FlowContainer.SuspendLayout();

            // Прокрутка
            FlowContainer.VerticalScroll.Value = Math.Clamp(
                ScrollBarCustom.Value,
                FlowContainer.VerticalScroll.Minimum,
                FlowContainer.VerticalScroll.Maximum
            );

            // Скрываем стандартный скролл (ДО ResumeLayout)
            //flowLayoutPanel1.VerticalScroll.Visible = false;

            // Возобновляем перерисовку
            FlowContainer.ResumeLayout(false);
        }

        private void SetupScrollBar()
        {
            // 3. Вычислить видимую высоту
            int visibleHeight = FlowContainer.ClientSize.Height;

            // 4. Настроить скроллбар
            ScrollBarCustom.Minimum = 0;
            ScrollBarCustom.Maximum = visibleHeight;
            ScrollBarCustom.ViewSize = (int)Math.Ceiling(visibleHeight / 4.0);
        }

        private void acrylicScrollBar1_MouseUp(object sender, MouseEventArgs e)
        {
            FlowContainer.AutoScroll = false;
            FlowContainer.VerticalScroll.Value = Math.Clamp(
                ScrollBarCustom.Value,
                FlowContainer.VerticalScroll.Minimum,
                FlowContainer.VerticalScroll.Maximum
            );
        }
    }

}
