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
            button1 = new Button();
            acrylicPanel2 = new AcrylicUI.Controls.AcrylicPanel();
            button2 = new Blueprint.Components.Button();
            MainContainer = new Blueprint.Components.MainContainer();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlDark;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(63, 29);
            button1.TabIndex = 0;
            button1.Text = "close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // acrylicPanel2
            // 
            acrylicPanel2.HasRoundedCorners = true;
            acrylicPanel2.Location = new Point(13, 65);
            acrylicPanel2.Name = "acrylicPanel2";
            acrylicPanel2.Size = new Size(50, 50);
            acrylicPanel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(13, 191);
            button2.Name = "button2";
            button2.Size = new Size(229, 68);
            button2.TabIndex = 4;
            // 
            // MainContainer
            // 
            MainContainer.BackColor = Color.FromArgb(19, 20, 21);
            MainContainer.Location = new Point(311, 48);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(1223, 829);
            MainContainer.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 900);
            Controls.Add(MainContainer);
            Controls.Add(button2);
            Controls.Add(acrylicPanel2);
            Controls.Add(button1);
            Name = "Form1";
            Padding = new Padding(20);
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private AcrylicUI.Controls.AcrylicPanel acrylicPanel2;
        private Components.Button button2;
        private Components.MainContainer MainContainer;
    }
}
