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
            acrylicPanel2 = new AcrylicUI.Controls.AcrylicPanel();
            MainContainer = new Blueprint.Components.MainContainer();
            button2 = new Blueprint.Components.Button();
            winClose1 = new Blueprint.Components.WinControls.WinClose();
            winMinimize1 = new Blueprint.Components.WinControls.WinMinimize();
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
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(23, 165);
            button2.Name = "button2";
            button2.Size = new Size(268, 76);
            button2.TabIndex = 6;
            // 
            // winClose1
            // 
            winClose1.BackColor = Color.FromArgb(19, 20, 21);
            winClose1.Location = new Point(13, 13);
            winClose1.Name = "winClose1";
            winClose1.Size = new Size(30, 30);
            winClose1.TabIndex = 7;
            // 
            // winMinimize1
            // 
            winMinimize1.BackColor = Color.FromArgb(19, 20, 21);
            winMinimize1.Location = new Point(49, 13);
            winMinimize1.Name = "winMinimize1";
            winMinimize1.Size = new Size(30, 30);
            winMinimize1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 900);
            Controls.Add(winMinimize1);
            Controls.Add(winClose1);
            Controls.Add(button2);
            Controls.Add(MainContainer);
            Controls.Add(acrylicPanel2);
            Name = "Form1";
            Padding = new Padding(20);
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private AcrylicUI.Controls.AcrylicPanel acrylicPanel2;
        private Components.MainContainer MainContainer;
        private Components.Button button2;
        private Components.WinControls.WinClose winClose1;
        private Components.WinControls.WinMinimize winMinimize1;
    }
}
