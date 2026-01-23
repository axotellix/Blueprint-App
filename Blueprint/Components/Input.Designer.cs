namespace Blueprint.Components {
    partial class Input {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            InputBackground = new PanelRound();
            InputTextbox = new AcrylicUI.Controls.AcrylicTextBox();
            InputBackground.SuspendLayout();
            SuspendLayout();
            // 
            // InputBackground
            // 
            InputBackground.AutoSize = true;
            InputBackground.BackColor = Color.FromArgb(35, 36, 39);
            InputBackground.Controls.Add(InputTextbox);
            InputBackground.Dock = DockStyle.Fill;
            InputBackground.Location = new Point(0, 0);
            InputBackground.Name = "InputBackground";
            InputBackground.Padding = new Padding(10);
            InputBackground.Size = new Size(487, 61);
            InputBackground.TabIndex = 0;
            // 
            // InputTextbox
            // 
            InputTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            InputTextbox.BackColor = Color.FromArgb(19, 20, 21);
            InputTextbox.BorderStyle = BorderStyle.None;
            InputTextbox.Font = new Font("NT Somic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputTextbox.ForeColor = Color.FromArgb(245, 245, 245);
            InputTextbox.Location = new Point(14, 19);
            InputTextbox.Multiline = true;
            InputTextbox.Name = "InputTextbox";
            InputTextbox.PlaceholderText = "введите название товара ...";
            InputTextbox.Size = new Size(185, 27);
            InputTextbox.TabIndex = 0;
            InputTextbox.Layout += InputTextbox_Layout;
            // 
            // Input
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(InputBackground);
            Name = "Input";
            Size = new Size(487, 61);
            Load += Input_Load;
            InputBackground.ResumeLayout(false);
            InputBackground.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PanelRound InputBackground;
        private AcrylicUI.Controls.AcrylicTextBox InputTextbox;
    }
}
