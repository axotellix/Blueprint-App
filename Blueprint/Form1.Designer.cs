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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainContainer = new Blueprint.Components.MainContainer();
            winClose1 = new Blueprint.Components.WinControls.WinClose();
            winMinimize1 = new Blueprint.Components.WinControls.WinMinimize();
            buttonIcon1 = new Blueprint.Components.ButtonIcon();
            buttonIcon2 = new Blueprint.Components.ButtonIcon();
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
            // buttonIcon1
            // 
            buttonIcon1.BackColor = Color.FromArgb(19, 20, 21);
            buttonIcon1.ForeColor = Color.FromArgb(224, 233, 241);
            buttonIcon1.Icon = (Image)resources.GetObject("buttonIcon1.Icon");
            buttonIcon1.IconInactive = (Image)resources.GetObject("buttonIcon1.IconInactive");
            buttonIcon1.Location = new Point(23, 140);
            buttonIcon1.Name = "buttonIcon1";
            buttonIcon1.Padding = new Padding(12);
            buttonIcon1.Size = new Size(270, 70);
            buttonIcon1.Style = Components.ButtonIcon.Styles.Normal;
            buttonIcon1.TabIndex = 9;
            buttonIcon1.TextContent = "button";
            // 
            // buttonIcon2
            // 
            buttonIcon2.BackColor = Color.Transparent;
            buttonIcon2.BorderWidth = 0;
            buttonIcon2.ForeColor = Color.FromArgb(96, 103, 110);
            buttonIcon2.Icon = (Image)resources.GetObject("buttonIcon2.Icon");
            buttonIcon2.IconInactive = (Image)resources.GetObject("buttonIcon2.IconInactive");
            buttonIcon2.Location = new Point(23, 225);
            buttonIcon2.Name = "buttonIcon2";
            buttonIcon2.Padding = new Padding(12);
            buttonIcon2.Size = new Size(270, 70);
            buttonIcon2.Style = Components.ButtonIcon.Styles.Inactive;
            buttonIcon2.TabIndex = 10;
            buttonIcon2.TextContent = "button";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(buttonIcon2);
            Controls.Add(buttonIcon1);
            Controls.Add(winMinimize1);
            Controls.Add(winClose1);
            Controls.Add(MainContainer);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Padding = new Padding(20);
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Components.MainContainer MainContainer;
        private Components.WinControls.WinClose winClose1;
        private Components.WinControls.WinMinimize winMinimize1;
        private Components.ButtonIcon buttonIcon1;
        private Components.ButtonIcon buttonIcon2;
    }
}
