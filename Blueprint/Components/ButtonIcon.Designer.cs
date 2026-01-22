namespace Blueprint.Components
{
    partial class ButtonIcon
    {
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
            IconBox = new PictureBox();
            Label = new Label();
            ((System.ComponentModel.ISupportInitialize)IconBox).BeginInit();
            SuspendLayout();
            // 
            // IconBox
            // 
            IconBox.Anchor = AnchorStyles.Left;
            IconBox.Location = new Point(12, 12);
            IconBox.Name = "IconBox";
            IconBox.Size = new Size(32, 31);
            IconBox.TabIndex = 0;
            IconBox.TabStop = false;
            // 
            // Label
            // 
            Label.Anchor = AnchorStyles.Left;
            Label.AutoSize = true;
            Label.Font = new Font("NT Somic", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label.ForeColor = SystemColors.Control;
            Label.Location = new Point(58, 18);
            Label.Name = "Label";
            Label.Size = new Size(79, 20);
            Label.TabIndex = 1;
            Label.Text = "Товары";
            // 
            // ButtonIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(Label);
            Controls.Add(IconBox);
            Name = "ButtonIcon";
            Padding = new Padding(12);
            Size = new Size(346, 56);
            Load += Button_Load;
            ((System.ComponentModel.ISupportInitialize)IconBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox IconBox;
        private Label Label;
    }
}
