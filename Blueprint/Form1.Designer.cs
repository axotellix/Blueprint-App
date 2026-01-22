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
            acrylicPanel2 = new AcrylicUI.Controls.AcrylicPanel();
            MainContainer = new Blueprint.Components.MainContainer();
            winClose1 = new Blueprint.Components.WinControls.WinClose();
            winMinimize1 = new Blueprint.Components.WinControls.WinMinimize();
            panel1 = new Panel();
            button1 = new Blueprint.Components.ButtonIcon();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // acrylicPanel2
            // 
            acrylicPanel2.HasRoundedCorners = true;
            acrylicPanel2.Location = new Point(13, 65);
            acrylicPanel2.Name = "acrylicPanel2";
            acrylicPanel2.Size = new Size(50, 50);
            acrylicPanel2.TabIndex = 2;
            // 
            // MainContainer
            // 
            MainContainer.BackColor = Color.FromArgb(19, 20, 21);
            MainContainer.Location = new Point(311, 48);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(1223, 829);
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
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 829);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(20, 122);
            button1.Name = "button1";
            button1.Padding = new Padding(12);
            button1.Size = new Size(252, 62);
            button1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 900);
            Controls.Add(winMinimize1);
            Controls.Add(winClose1);
            Controls.Add(MainContainer);
            Controls.Add(acrylicPanel2);
            Controls.Add(panel1);
            Name = "Form1";
            Padding = new Padding(20);
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AcrylicUI.Controls.AcrylicPanel acrylicPanel2;
        private Components.MainContainer MainContainer;
        private Components.WinControls.WinClose winClose1;
        private Components.WinControls.WinMinimize winMinimize1;
        private Panel panel1;
        private Components.ButtonIcon button1;
    }
}
