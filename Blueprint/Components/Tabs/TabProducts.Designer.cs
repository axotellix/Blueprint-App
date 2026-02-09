namespace Blueprint.Components.Tabs {
    partial class TabProducts {
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
            Lable_ProductsAmount = new Label();
            Label_Username = new Label();
            FlowContainer = new FlowLayoutPanel();
            productCard1 = new ProductCard();
            productCard2 = new ProductCard();
            Scrollbarz = new AcrylicUI.Controls.AcrylicScrollBar();
            ScrollBarCustom = new AcrylicUI.Controls.AcrylicScrollBar();
            panel1 = new Panel();
            input1 = new Input();
            button1 = new Button();
            FlowContainer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lable_ProductsAmount
            // 
            Lable_ProductsAmount.AutoSize = true;
            Lable_ProductsAmount.Font = new Font("NT Somic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Lable_ProductsAmount.ForeColor = SystemColors.ControlDark;
            Lable_ProductsAmount.Location = new Point(28, 66);
            Lable_ProductsAmount.Name = "Lable_ProductsAmount";
            Lable_ProductsAmount.Size = new Size(108, 18);
            Lable_ProductsAmount.TabIndex = 7;
            Lable_ProductsAmount.Text = "всего: 0 шт.";
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.Font = new Font("NT Somic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_Username.ForeColor = SystemColors.Control;
            Label_Username.Location = new Point(23, 34);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(111, 28);
            Label_Username.TabIndex = 6;
            Label_Username.Text = "Товары";
            // 
            // FlowContainer
            // 
            FlowContainer.AutoScroll = true;
            FlowContainer.Controls.Add(productCard1);
            FlowContainer.Controls.Add(productCard2);
            FlowContainer.Dock = DockStyle.Fill;
            FlowContainer.Location = new Point(0, 0);
            FlowContainer.Name = "FlowContainer";
            FlowContainer.Size = new Size(1165, 691);
            FlowContainer.TabIndex = 8;
            // 
            // productCard1
            // 
            productCard1.BackColor = Color.FromArgb(27, 29, 31);
            productCard1.Location = new Point(0, 0);
            productCard1.Margin = new Padding(0, 0, 20, 20);
            productCard1.Name = "productCard1";
            productCard1.Padding = new Padding(10);
            productCard1.Size = new Size(260, 310);
            productCard1.TabIndex = 0;
            // 
            // productCard2
            // 
            productCard2.BackColor = Color.FromArgb(27, 29, 31);
            productCard2.Location = new Point(280, 0);
            productCard2.Margin = new Padding(0, 0, 20, 20);
            productCard2.Name = "productCard2";
            productCard2.Padding = new Padding(10);
            productCard2.Size = new Size(260, 310);
            productCard2.TabIndex = 1;
            // 
            // Scrollbarz
            // 
            Scrollbarz.Location = new Point(0, 0);
            Scrollbarz.Name = "Scrollbarz";
            Scrollbarz.Size = new Size(0, 0);
            Scrollbarz.TabIndex = 0;
            // 
            // ScrollBarCustom
            // 
            ScrollBarCustom.BackColor = SystemColors.ActiveCaptionText;
            ScrollBarCustom.Location = new Point(1199, 126);
            ScrollBarCustom.Name = "ScrollBarCustom";
            ScrollBarCustom.Size = new Size(15, 680);
            ScrollBarCustom.TabIndex = 9;
            ScrollBarCustom.Text = "acrylicScrollBar1";
            ScrollBarCustom.ValueChanged += acrylicScrollBar1_ValueChanged;
            ScrollBarCustom.MouseUp += acrylicScrollBar1_MouseUp;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(FlowContainer);
            panel1.Location = new Point(28, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 691);
            panel1.TabIndex = 10;
            // 
            // input1
            // 
            input1.BackColor = Color.Transparent;
            input1.Location = new Point(735, 34);
            input1.Name = "input1";
            input1.Size = new Size(277, 36);
            input1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 20, 21);
            button1.ButtonSize = new Size(110, 36);
            button1.ForeColor = Color.FromArgb(224, 233, 241);
            button1.Location = new Point(1018, 34);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(110, 36);
            button1.Style = Button.Styles.Normal;
            button1.TabIndex = 12;
            button1.TextContent = "поиск";
            // 
            // TabProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(input1);
            Controls.Add(ScrollBarCustom);
            Controls.Add(Scrollbarz);
            Controls.Add(Lable_ProductsAmount);
            Controls.Add(Label_Username);
            Controls.Add(panel1);
            Name = "TabProducts";
            Padding = new Padding(20);
            Size = new Size(1250, 829);
            Load += TabProducts_Load;
            FlowContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lable_ProductsAmount;
        private Label Label_Username;
        private FlowLayoutPanel FlowContainer;
        private ProductCard productCard1;
        private ProductCard productCard2;
        private AcrylicUI.Controls.AcrylicScrollBar Scrollbarz;
        private AcrylicUI.Controls.AcrylicScrollBar ScrollBarCustom;
        private Panel panel1;
        private Input input1;
        private Button button1;
    }
}
