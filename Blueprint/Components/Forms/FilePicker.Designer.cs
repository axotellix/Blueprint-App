namespace Blueprint.Components.Forms {
    partial class FilePicker {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePicker));
            ImageIcon = new PictureBox();
            Placeholder = new Label();
            FilePreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImageIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilePreview).BeginInit();
            SuspendLayout();
            // 
            // ImageIcon
            // 
            ImageIcon.BackColor = Color.Transparent;
            ImageIcon.Image = (Image)resources.GetObject("ImageIcon.Image");
            ImageIcon.Location = new Point(164, 70);
            ImageIcon.Name = "ImageIcon";
            ImageIcon.Size = new Size(0, 31);
            ImageIcon.SizeMode = PictureBoxSizeMode.Zoom;
            ImageIcon.TabIndex = 0;
            ImageIcon.TabStop = false;
            ImageIcon.Layout += ImageIcon_Layout;
            // 
            // Placeholder
            // 
            Placeholder.AutoSize = true;
            Placeholder.BackColor = Color.Transparent;
            Placeholder.Font = new Font("NT Somic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Placeholder.ForeColor = SystemColors.Control;
            Placeholder.Location = new Point(75, 120);
            Placeholder.Name = "Placeholder";
            Placeholder.Size = new Size(229, 18);
            Placeholder.TabIndex = 8;
            Placeholder.Text = "нажмите, чтобы добавить";
            // 
            // FilePreview
            // 
            FilePreview.BackColor = Color.Transparent;
            FilePreview.Location = new Point(16, 19);
            FilePreview.Name = "FilePreview";
            FilePreview.Size = new Size(133, 130);
            FilePreview.SizeMode = PictureBoxSizeMode.Zoom;
            FilePreview.TabIndex = 9;
            FilePreview.TabStop = false;
            FilePreview.Visible = false;
            FilePreview.Layout += FilePreview_Layout;
            // 
            // FilePicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(Placeholder);
            Controls.Add(ImageIcon);
            Controls.Add(FilePreview);
            Name = "FilePicker";
            Size = new Size(391, 222);
            Load += FilePicker_Load;
            ((System.ComponentModel.ISupportInitialize)ImageIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilePreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImageIcon;
        private Label Placeholder;
        private PictureBox FilePreview;
    }
}
