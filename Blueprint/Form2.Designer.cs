namespace Blueprint {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            winClose1 = new Blueprint.Components.WinControls.WinClose();
            winMinimize1 = new Blueprint.Components.WinControls.WinMinimize();
            mainContainer1 = new Blueprint.Components.MainContainer();
            FlowContainer = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // winClose1
            // 
            winClose1.BackColor = Color.FromArgb(19, 20, 21);
            winClose1.BorderWidth = 0;
            winClose1.Location = new Point(12, 12);
            winClose1.Name = "winClose1";
            winClose1.Size = new Size(30, 30);
            winClose1.TabIndex = 0;
            // 
            // winMinimize1
            // 
            winMinimize1.BackColor = Color.FromArgb(19, 20, 21);
            winMinimize1.BorderWidth = 0;
            winMinimize1.Location = new Point(48, 12);
            winMinimize1.Name = "winMinimize1";
            winMinimize1.Size = new Size(30, 30);
            winMinimize1.TabIndex = 1;
            // 
            // mainContainer1
            // 
            mainContainer1.BackColor = Color.FromArgb(19, 20, 21);
            mainContainer1.Location = new Point(31, 59);
            mainContainer1.Name = "mainContainer1";
            mainContainer1.Size = new Size(1160, 674);
            mainContainer1.TabIndex = 2;
            // 
            // FlowContainer
            // 
            FlowContainer.BackColor = Color.Transparent;
            FlowContainer.Location = new Point(48, 78);
            FlowContainer.Name = "FlowContainer";
            FlowContainer.Size = new Size(1123, 635);
            FlowContainer.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 762);
            Controls.Add(FlowContainer);
            Controls.Add(mainContainer1);
            Controls.Add(winMinimize1);
            Controls.Add(winClose1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Components.WinControls.WinClose winClose1;
        private Components.WinControls.WinMinimize winMinimize1;
        private Components.MainContainer mainContainer1;
        private FlowLayoutPanel FlowContainer;
    }
}