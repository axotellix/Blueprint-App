namespace Blueprint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainContainer = new Blueprint.Components.MainContainer();
            winClose1 = new Blueprint.Components.WinControls.WinClose();
            winMinimize1 = new Blueprint.Components.WinControls.WinMinimize();
            SidebarMain = new Blueprint.Components.Sidebar();
            Tab = new Label();
            SuspendLayout();
            // 
            // MainContainer
            // 
            MainContainer.BackColor = Color.FromArgb(19, 20, 21);
            MainContainer.BorderRadius = 20;
            MainContainer.Location = new Point(327, 48);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(1250, 829);
            MainContainer.TabIndex = 5;
            // 
            // winClose1
            // 
            winClose1.BackColor = Color.FromArgb(19, 20, 21);
            winClose1.BorderWidth = 0;
            winClose1.Location = new Point(13, 13);
            winClose1.Name = "winClose1";
            winClose1.Size = new Size(30, 30);
            winClose1.TabIndex = 7;
            // 
            // winMinimize1
            // 
            winMinimize1.BackColor = Color.FromArgb(19, 20, 21);
            winMinimize1.BorderWidth = 0;
            winMinimize1.Location = new Point(49, 13);
            winMinimize1.Name = "winMinimize1";
            winMinimize1.Size = new Size(30, 30);
            winMinimize1.TabIndex = 8;
            // 
            // SidebarMain
            // 
            SidebarMain.BackColor = SystemColors.Desktop;
            SidebarMain.Location = new Point(2, 48);
            SidebarMain.Name = "SidebarMain";
            SidebarMain.Padding = new Padding(15);
            SidebarMain.Size = new Size(320, 829);
            SidebarMain.TabIndex = 9;
            // 
            // Tab
            // 
            Tab.AutoSize = true;
            Tab.BackColor = Color.Transparent;
            Tab.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab.ForeColor = SystemColors.Control;
            Tab.Location = new Point(940, 409);
            Tab.Name = "Tab";
            Tab.Size = new Size(45, 54);
            Tab.TabIndex = 10;
            Tab.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(Tab);
            Controls.Add(SidebarMain);
            Controls.Add(winMinimize1);
            Controls.Add(winClose1);
            Controls.Add(MainContainer);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Padding = new Padding(20);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Components.MainContainer MainContainer;
        private Components.WinControls.WinClose winClose1;
        private Components.WinControls.WinMinimize winMinimize1;
        private Components.Sidebar SidebarMain;
        private Label Tab;
    }
}
