namespace Blueprint.Components {
    partial class Button{
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
            Label = new Label();
            SuspendLayout();
            // 
            // Label
            // 
            Label.Anchor = AnchorStyles.None;
            Label.AutoSize = true;
            Label.BackColor = Color.Transparent;
            Label.Font = new Font("NT Somic", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label.ForeColor = SystemColors.Control;
            Label.Location = new Point(128, 15);
            Label.Name = "Label";
            Label.Size = new Size(79, 20);
            Label.TabIndex = 3;
            Label.Text = "Товары";
            // 
            // Button
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(Label);
            Name = "Button";
            Padding = new Padding(10);
            Size = new Size(346, 52);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label;
    }
}
