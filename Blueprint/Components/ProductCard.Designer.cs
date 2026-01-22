namespace Blueprint.Components {
    partial class ProductCard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            ProductPicture = new PictureBox();
            BtnEdit = new Button();
            Label_About = new Label();
            Label_Company = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).BeginInit();
            SuspendLayout();
            // 
            // ProductPicture
            // 
            ProductPicture.BackColor = Color.Transparent;
            ProductPicture.Image = (Image)resources.GetObject("ProductPicture.Image");
            ProductPicture.Location = new Point(13, 13);
            ProductPicture.Name = "ProductPicture";
            ProductPicture.Size = new Size(234, 150);
            ProductPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ProductPicture.TabIndex = 19;
            ProductPicture.TabStop = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.FromArgb(38, 41, 43);
            BtnEdit.ButtonSize = new Size(234, 46);
            BtnEdit.ForeColor = Color.FromArgb(224, 233, 241);
            BtnEdit.Location = new Point(13, 251);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Padding = new Padding(10);
            BtnEdit.Size = new Size(136, 0);
            BtnEdit.Style = Button.Styles.Light;
            BtnEdit.TabIndex = 18;
            BtnEdit.TextContent = "редактировать";
            // 
            // Label_About
            // 
            Label_About.AutoSize = true;
            Label_About.BackColor = Color.Transparent;
            Label_About.Font = new Font("NT Somic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_About.ForeColor = SystemColors.ControlDark;
            Label_About.Location = new Point(13, 210);
            Label_About.Name = "Label_About";
            Label_About.Size = new Size(71, 18);
            Label_About.TabIndex = 16;
            Label_About.Text = "1000 р.";
            // 
            // Label_Company
            // 
            Label_Company.AutoSize = true;
            Label_Company.BackColor = Color.Transparent;
            Label_Company.Font = new Font("NT Somic Semibold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Label_Company.ForeColor = SystemColors.Control;
            Label_Company.Location = new Point(13, 180);
            Label_Company.Name = "Label_Company";
            Label_Company.Size = new Size(224, 20);
            Label_Company.TabIndex = 17;
            Label_Company.Text = "Металлические балки";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(ProductPicture);
            Controls.Add(BtnEdit);
            Controls.Add(Label_About);
            Controls.Add(Label_Company);
            Name = "ProductCard";
            Padding = new Padding(10);
            Size = new Size(260, 310);
            Load += ProductCard_Load;
            ((System.ComponentModel.ISupportInitialize)ProductPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProductPicture;
        private Button BtnEdit;
        private Label Label_About;
        private Label Label_Company;
    }
}
