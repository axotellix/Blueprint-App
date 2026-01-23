namespace Blueprint.Components.Forms {
    partial class InputGroup {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputGroup));
            InputLabel = new Label();
            InputTextbox = new Input();
            ErrImg = new PictureBox();
            ErrMsg = new Label();
            ((System.ComponentModel.ISupportInitialize)ErrImg).BeginInit();
            SuspendLayout();
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.BackColor = Color.Transparent;
            InputLabel.Font = new Font("NT Somic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputLabel.ForeColor = SystemColors.ButtonFace;
            InputLabel.Location = new Point(17, 14);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(53, 17);
            InputLabel.TabIndex = 0;
            InputLabel.Text = "label1";
            // 
            // InputTextbox
            // 
            InputTextbox.BackColor = Color.Transparent;
            InputTextbox.Location = new Point(13, 39);
            InputTextbox.Name = "InputTextbox";
            InputTextbox.Size = new Size(502, 42);
            InputTextbox.TabIndex = 1;
            // 
            // ErrImg
            // 
            ErrImg.Image = (Image)resources.GetObject("ErrImg.Image");
            ErrImg.Location = new Point(22, 87);
            ErrImg.Name = "ErrImg";
            ErrImg.Size = new Size(16, 21);
            ErrImg.SizeMode = PictureBoxSizeMode.Zoom;
            ErrImg.TabIndex = 2;
            ErrImg.TabStop = false;
            ErrImg.Visible = false;
            // 
            // ErrMsg
            // 
            ErrMsg.AutoSize = true;
            ErrMsg.BackColor = Color.Transparent;
            ErrMsg.Font = new Font("NT Somic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ErrMsg.ForeColor = Color.Salmon;
            ErrMsg.Location = new Point(44, 91);
            ErrMsg.Name = "ErrMsg";
            ErrMsg.Size = new Size(51, 15);
            ErrMsg.TabIndex = 3;
            ErrMsg.Text = "label2";
            // 
            // InputGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ErrMsg);
            Controls.Add(ErrImg);
            Controls.Add(InputTextbox);
            Controls.Add(InputLabel);
            Name = "InputGroup";
            Padding = new Padding(10);
            Size = new Size(531, 118);
            Load += InputGroup_Load;
            ((System.ComponentModel.ISupportInitialize)ErrImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InputLabel;
        private Input InputTextbox;
        private PictureBox ErrImg;
        private Label ErrMsg;
    }
}
