namespace Blueprint.Components.WinControls
{
    partial class WinClose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinClose));
            Icon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Icon).BeginInit();
            SuspendLayout();
            // 
            // Icon
            // 
            Icon.BackColor = Color.Transparent;
            Icon.BackgroundImageLayout = ImageLayout.Center;
            Icon.Dock = DockStyle.Fill;
            Icon.Image = (Image)resources.GetObject("Icon.Image");
            Icon.InitialImage = null;
            Icon.Location = new Point(0, 0);
            Icon.Name = "Icon";
            Icon.Size = new Size(24, 24);
            Icon.SizeMode = PictureBoxSizeMode.Zoom;
            Icon.TabIndex = 0;
            Icon.TabStop = false;
            // 
            // WinClose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderWidth = 0;
            Controls.Add(Icon);
            Name = "WinClose";
            Size = new Size(24, 24);
            Load += WinClose_Load;
            ((System.ComponentModel.ISupportInitialize)Icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Icon;
    }
}
