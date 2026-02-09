namespace Blueprint.Components.Tabs {
    partial class TabCreateProduct {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabCreateProduct));
            Label_Username = new Label();
            input_ProductName = new Blueprint.Components.Forms.InputGroup();
            input_ProductPrice = new Blueprint.Components.Forms.InputGroup();
            btn_Create = new Button();
            input_ProductImage = new Blueprint.Components.Forms.FilePicker();
            InputLabel = new Label();
            ErrMsg_ImgPicker = new Label();
            ErrImg_ImgPicker = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ErrImg_ImgPicker).BeginInit();
            SuspendLayout();
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.Font = new Font("NT Somic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_Username.ForeColor = SystemColors.Control;
            Label_Username.Location = new Point(23, 34);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(242, 28);
            Label_Username.TabIndex = 7;
            Label_Username.Text = "Создание товара";
            // 
            // input_ProductName
            // 
            input_ProductName.BackColor = Color.Transparent;
            input_ProductName.ErrMsgText = null;
            input_ProductName.LabelText = "название товара";
            input_ProductName.Location = new Point(18, 113);
            input_ProductName.Name = "input_ProductName";
            input_ProductName.Padding = new Padding(10);
            input_ProductName.Placeholder = "введите название товара";
            input_ProductName.Size = new Size(557, 148);
            input_ProductName.TabIndex = 8;
            // 
            // input_ProductPrice
            // 
            input_ProductPrice.BackColor = Color.Transparent;
            input_ProductPrice.ErrMsgText = null;
            input_ProductPrice.LabelText = "цена товара";
            input_ProductPrice.Location = new Point(18, 238);
            input_ProductPrice.Name = "input_ProductPrice";
            input_ProductPrice.Padding = new Padding(10);
            input_ProductPrice.Placeholder = "введите цену товара";
            input_ProductPrice.Size = new Size(557, 148);
            input_ProductPrice.TabIndex = 9;
            // 
            // btn_Create
            // 
            btn_Create.BackColor = Color.FromArgb(38, 41, 43);
            btn_Create.ButtonSize = new Size(170, 42);
            btn_Create.ForeColor = Color.FromArgb(224, 233, 241);
            btn_Create.Location = new Point(33, 405);
            btn_Create.Name = "btn_Create";
            btn_Create.Padding = new Padding(10);
            btn_Create.Size = new Size(170, 42);
            btn_Create.Style = Button.Styles.Light;
            btn_Create.TabIndex = 10;
            btn_Create.TextContent = "создать";
            btn_Create.Click += btn_Create_Click;
            // 
            // input_ProductImage
            // 
            input_ProductImage.BackColor = Color.FromArgb(19, 20, 21);
            input_ProductImage.Location = new Point(631, 127);
            input_ProductImage.Name = "input_ProductImage";
            input_ProductImage.Size = new Size(373, 216);
            input_ProductImage.TabIndex = 11;
            input_ProductImage.Click += input_ProductImage_Click;
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.BackColor = Color.Transparent;
            InputLabel.Font = new Font("NT Somic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputLabel.ForeColor = SystemColors.ButtonFace;
            InputLabel.Location = new Point(642, 98);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(108, 17);
            InputLabel.TabIndex = 12;
            InputLabel.Text = "фото товара";
            // 
            // ErrMsg_ImgPicker
            // 
            ErrMsg_ImgPicker.AutoSize = true;
            ErrMsg_ImgPicker.BackColor = Color.Transparent;
            ErrMsg_ImgPicker.Font = new Font("NT Somic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ErrMsg_ImgPicker.ForeColor = Color.Salmon;
            ErrMsg_ImgPicker.Location = new Point(681, 354);
            ErrMsg_ImgPicker.Name = "ErrMsg_ImgPicker";
            ErrMsg_ImgPicker.Size = new Size(51, 15);
            ErrMsg_ImgPicker.TabIndex = 14;
            ErrMsg_ImgPicker.Text = "label2";
            ErrMsg_ImgPicker.Visible = false;
            // 
            // ErrImg_ImgPicker
            // 
            ErrImg_ImgPicker.Image = (Image)resources.GetObject("ErrImg_ImgPicker.Image");
            ErrImg_ImgPicker.Location = new Point(659, 350);
            ErrImg_ImgPicker.Name = "ErrImg_ImgPicker";
            ErrImg_ImgPicker.Size = new Size(16, 21);
            ErrImg_ImgPicker.SizeMode = PictureBoxSizeMode.Zoom;
            ErrImg_ImgPicker.TabIndex = 13;
            ErrImg_ImgPicker.TabStop = false;
            ErrImg_ImgPicker.Visible = false;
            // 
            // TabCreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ErrMsg_ImgPicker);
            Controls.Add(ErrImg_ImgPicker);
            Controls.Add(InputLabel);
            Controls.Add(input_ProductImage);
            Controls.Add(btn_Create);
            Controls.Add(input_ProductPrice);
            Controls.Add(input_ProductName);
            Controls.Add(Label_Username);
            Name = "TabCreateProduct";
            Padding = new Padding(20);
            Size = new Size(1250, 829);
            ((System.ComponentModel.ISupportInitialize)ErrImg_ImgPicker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Username;
        private Forms.InputGroup input_ProductName;
        private Forms.InputGroup input_ProductPrice;
        private Forms.FilePicker input_ProductImage;
        private Label InputLabel;
        public Button btn_Create;
        private Label ErrMsg_ImgPicker;
        private PictureBox ErrImg_ImgPicker;
    }
}
