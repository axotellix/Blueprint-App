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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sidebar));
            Avatar = new AcrylicUI.Controls.AcrylicPanel();
            label1 = new Label();
            label2 = new Label();
            buttonIcon1 = new ButtonIcon();
            buttonIcon2 = new ButtonIcon();
            buttonIcon3 = new ButtonIcon();
            buttonIcon4 = new ButtonIcon();
            Badge = new System.Windows.Forms.Panel();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            buttonIcon5 = new ButtonIcon();
            Badge.SuspendLayout();
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
            label1.Font = new Font("NT Somic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            // buttonIcon1
            // 
            buttonIcon1.BackColor = Color.FromArgb(19, 20, 21);
            buttonIcon1.ForeColor = Color.FromArgb(224, 233, 241);
            buttonIcon1.Icon = (Image)resources.GetObject("buttonIcon1.Icon");
            buttonIcon1.IconInactive = (Image)resources.GetObject("buttonIcon1.IconInactive");
            buttonIcon1.Location = new Point(18, 145);
            buttonIcon1.Name = "buttonIcon1";
            buttonIcon1.Padding = new Padding(12);
            buttonIcon1.Size = new Size(284, 57);
            buttonIcon1.Style = ButtonIcon.Styles.Normal;
            buttonIcon1.TabIndex = 6;
            buttonIcon1.TextContent = "Товары";
            // 
            // buttonIcon2
            // 
            buttonIcon2.BackColor = Color.Transparent;
            buttonIcon2.BorderWidth = 0;
            buttonIcon2.ForeColor = Color.FromArgb(96, 103, 110);
            buttonIcon2.Icon = (Image)resources.GetObject("buttonIcon2.Icon");
            buttonIcon2.IconInactive = (Image)resources.GetObject("buttonIcon2.IconInactive");
            buttonIcon2.Location = new Point(18, 208);
            buttonIcon2.Name = "buttonIcon2";
            buttonIcon2.Padding = new Padding(12);
            buttonIcon2.Size = new Size(284, 57);
            buttonIcon2.Style = ButtonIcon.Styles.Inactive;
            buttonIcon2.TabIndex = 7;
            buttonIcon2.TextContent = "Создать товар";
            // 
            // buttonIcon3
            // 
            buttonIcon3.BackColor = Color.Transparent;
            buttonIcon3.BorderWidth = 0;
            buttonIcon3.ForeColor = Color.FromArgb(96, 103, 110);
            buttonIcon3.Icon = (Image)resources.GetObject("buttonIcon3.Icon");
            buttonIcon3.IconInactive = (Image)resources.GetObject("buttonIcon3.IconInactive");
            buttonIcon3.Location = new Point(18, 271);
            buttonIcon3.Name = "buttonIcon3";
            buttonIcon3.Padding = new Padding(12);
            buttonIcon3.Size = new Size(284, 57);
            buttonIcon3.Style = ButtonIcon.Styles.Inactive;
            buttonIcon3.TabIndex = 8;
            buttonIcon3.TextContent = "Заказы";
            // 
            // buttonIcon4
            // 
            buttonIcon4.BackColor = Color.Transparent;
            buttonIcon4.BorderWidth = 0;
            buttonIcon4.ForeColor = Color.FromArgb(96, 103, 110);
            buttonIcon4.Icon = (Image)resources.GetObject("buttonIcon4.Icon");
            buttonIcon4.IconInactive = (Image)resources.GetObject("buttonIcon4.IconInactive");
            buttonIcon4.Location = new Point(18, 334);
            buttonIcon4.Name = "buttonIcon4";
            buttonIcon4.Padding = new Padding(12);
            buttonIcon4.Size = new Size(284, 57);
            buttonIcon4.Style = ButtonIcon.Styles.Inactive;
            buttonIcon4.TabIndex = 9;
            buttonIcon4.TextContent = "Клиенты";
            // 
            // Badge
            // 
            Badge.Controls.Add(label4);
            Badge.Controls.Add(button1);
            Badge.Controls.Add(label3);
            Badge.Location = new Point(18, 534);
            Badge.Name = "Badge";
            Badge.Padding = new Padding(18);
            Badge.Size = new Size(284, 170);
            Badge.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("NT Somic Semibold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(22, 32);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 11;
            label3.Text = "BLUEPRINT";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(21, 100);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(242, 49);
            button1.Style = Button.Styles.Normal;
            button1.TabIndex = 12;
            button1.TextContent = "button";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("NT Somic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(23, 56);
            label4.Name = "label4";
            label4.Size = new Size(200, 18);
            label4.TabIndex = 11;
            label4.Text = "building materials store";
            // 
            // buttonIcon5
            // 
            buttonIcon5.BackColor = Color.Transparent;
            buttonIcon5.BorderWidth = 0;
            buttonIcon5.ForeColor = Color.FromArgb(96, 103, 110);
            buttonIcon5.Icon = (Image)resources.GetObject("buttonIcon5.Icon");
            buttonIcon5.IconInactive = (Image)resources.GetObject("buttonIcon5.IconInactive");
            buttonIcon5.Location = new Point(18, 760);
            buttonIcon5.Name = "buttonIcon5";
            buttonIcon5.Padding = new Padding(12);
            buttonIcon5.Size = new Size(284, 51);
            buttonIcon5.Style = ButtonIcon.Styles.Inactive;
            buttonIcon5.TabIndex = 11;
            buttonIcon5.TextContent = "Выйти";
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            Controls.Add(buttonIcon5);
            Controls.Add(Badge);
            Controls.Add(buttonIcon4);
            Controls.Add(buttonIcon3);
            Controls.Add(buttonIcon2);
            Controls.Add(buttonIcon1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Avatar);
            Name = "Sidebar";
            Padding = new Padding(15);
            Size = new Size(320, 829);
            Badge.ResumeLayout(false);
            Badge.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AcrylicUI.Controls.AcrylicPanel Avatar;
        private Label label1;
        private Label label2;
        private ButtonIcon buttonIcon1;
        private ButtonIcon buttonIcon2;
        private ButtonIcon buttonIcon3;
        private ButtonIcon buttonIcon4;
        private Panel Badge;
        private Label label3;
        private Button button1;
        private Label label4;
        private ButtonIcon buttonIcon5;
    }
}
