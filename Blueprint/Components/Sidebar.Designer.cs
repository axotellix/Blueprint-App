namespace Blueprint.Components
{
    partial class Sidebar
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
            Avatar = new AcrylicUI.Controls.AcrylicPanel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Avatar
            // 
            Avatar.BackColor = SystemColors.Control;
            Avatar.HasRoundedCorners = true;
            Avatar.Location = new Point(18, 45);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(50, 50);
            Avatar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("NT Somic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(79, 49);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 4;
            label1.Text = "John Doe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("NT Somic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(79, 72);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 5;
            label2.Text = "admin";
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Avatar);
            Name = "Sidebar";
            Padding = new Padding(15);
            Size = new Size(300, 829);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AcrylicUI.Controls.AcrylicPanel Avatar;
        private Label label1;
        private Label label2;
    }
}
