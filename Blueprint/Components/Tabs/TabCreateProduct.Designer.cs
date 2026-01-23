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
            Label_Username = new Label();
            inputGroup1 = new Blueprint.Components.Forms.InputGroup();
            inputGroup2 = new Blueprint.Components.Forms.InputGroup();
            button1 = new Button();
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
            // inputGroup1
            // 
            inputGroup1.BackColor = Color.Black;
            inputGroup1.ErrMsgText = null;
            inputGroup1.LabelText = "название товара";
            inputGroup1.Location = new Point(18, 104);
            inputGroup1.Name = "inputGroup1";
            inputGroup1.Padding = new Padding(10);
            inputGroup1.Placeholder = "введите название товара";
            inputGroup1.Size = new Size(557, 148);
            inputGroup1.TabIndex = 8;
            // 
            // inputGroup2
            // 
            inputGroup2.BackColor = Color.Black;
            inputGroup2.ErrMsgText = null;
            inputGroup2.LabelText = "цена товара";
            inputGroup2.Location = new Point(18, 229);
            inputGroup2.Name = "inputGroup2";
            inputGroup2.Padding = new Padding(10);
            inputGroup2.Placeholder = "введите цену товара";
            inputGroup2.Size = new Size(557, 148);
            inputGroup2.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 20, 21);
            button1.ButtonSize = new Size(170, 42);
            button1.ForeColor = Color.FromArgb(224, 233, 241);
            button1.Location = new Point(32, 383);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(140, 42);
            button1.Style = Button.Styles.Normal;
            button1.TabIndex = 10;
            button1.TextContent = "создать";
            // 
            // TabCreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(button1);
            Controls.Add(inputGroup2);
            Controls.Add(inputGroup1);
            Controls.Add(Label_Username);
            Name = "TabCreateProduct";
            Padding = new Padding(20);
            Size = new Size(1250, 829);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Username;
        private Forms.InputGroup inputGroup1;
        private Forms.InputGroup inputGroup2;
        private Button button1;
    }
}
