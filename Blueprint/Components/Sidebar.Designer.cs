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
            Label_Username = new Label();
            Lable_Usertype = new Label();
            Nav_Products = new ButtonIcon();
            Nav_Create = new ButtonIcon();
            Nav_Orders = new ButtonIcon();
            Nav_Clients = new ButtonIcon();
            Label_About = new Label();
            Label_Company = new Label();
            Btn_Logout = new ButtonIcon();
            panelRound1 = new PanelRound();
            button1 = new Button();
            panelRound1.SuspendLayout();
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
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.Font = new Font("NT Somic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_Username.ForeColor = SystemColors.Control;
            Label_Username.Location = new Point(79, 49);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(112, 23);
            Label_Username.TabIndex = 4;
            Label_Username.Text = "John Doe";
            // 
            // Lable_Usertype
            // 
            Lable_Usertype.AutoSize = true;
            Lable_Usertype.Font = new Font("NT Somic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Lable_Usertype.ForeColor = SystemColors.ControlDark;
            Lable_Usertype.Location = new Point(79, 72);
            Lable_Usertype.Name = "Lable_Usertype";
            Lable_Usertype.Size = new Size(59, 18);
            Lable_Usertype.TabIndex = 5;
            Lable_Usertype.Text = "admin";
            // 
            // Nav_Products
            // 
            Nav_Products.BackColor = Color.FromArgb(19, 20, 21);
            Nav_Products.ForeColor = Color.FromArgb(224, 233, 241);
            Nav_Products.Icon = (Image)resources.GetObject("Nav_Products.Icon");
            Nav_Products.IconInactive = (Image)resources.GetObject("Nav_Products.IconInactive");
            Nav_Products.Location = new Point(18, 145);
            Nav_Products.Name = "Nav_Products";
            Nav_Products.Padding = new Padding(12);
            Nav_Products.Size = new Size(284, 57);
            Nav_Products.Style = ButtonIcon.Styles.Normal;
            Nav_Products.TabIndex = 6;
            Nav_Products.TextContent = "Товары";
            // 
            // Nav_Create
            // 
            Nav_Create.BackColor = Color.Transparent;
            Nav_Create.BorderWidth = 0;
            Nav_Create.ForeColor = Color.FromArgb(96, 103, 110);
            Nav_Create.Icon = (Image)resources.GetObject("Nav_Create.Icon");
            Nav_Create.IconInactive = (Image)resources.GetObject("Nav_Create.IconInactive");
            Nav_Create.Location = new Point(18, 208);
            Nav_Create.Name = "Nav_Create";
            Nav_Create.Padding = new Padding(12);
            Nav_Create.Size = new Size(284, 57);
            Nav_Create.Style = ButtonIcon.Styles.Inactive;
            Nav_Create.TabIndex = 7;
            Nav_Create.TextContent = "Создать товар";
            // 
            // Nav_Orders
            // 
            Nav_Orders.BackColor = Color.Transparent;
            Nav_Orders.BorderWidth = 0;
            Nav_Orders.ForeColor = Color.FromArgb(96, 103, 110);
            Nav_Orders.Icon = (Image)resources.GetObject("Nav_Orders.Icon");
            Nav_Orders.IconInactive = (Image)resources.GetObject("Nav_Orders.IconInactive");
            Nav_Orders.Location = new Point(18, 271);
            Nav_Orders.Name = "Nav_Orders";
            Nav_Orders.Padding = new Padding(12);
            Nav_Orders.Size = new Size(284, 57);
            Nav_Orders.Style = ButtonIcon.Styles.Inactive;
            Nav_Orders.TabIndex = 8;
            Nav_Orders.TextContent = "Заказы";
            // 
            // Nav_Clients
            // 
            Nav_Clients.BackColor = Color.Transparent;
            Nav_Clients.BorderWidth = 0;
            Nav_Clients.ForeColor = Color.FromArgb(96, 103, 110);
            Nav_Clients.Icon = (Image)resources.GetObject("Nav_Clients.Icon");
            Nav_Clients.IconInactive = (Image)resources.GetObject("Nav_Clients.IconInactive");
            Nav_Clients.Location = new Point(18, 334);
            Nav_Clients.Name = "Nav_Clients";
            Nav_Clients.Padding = new Padding(12);
            Nav_Clients.Size = new Size(284, 57);
            Nav_Clients.Style = ButtonIcon.Styles.Inactive;
            Nav_Clients.TabIndex = 9;
            Nav_Clients.TextContent = "Клиенты";
            // 
            // Label_About
            // 
            Label_About.AutoSize = true;
            Label_About.BackColor = Color.Transparent;
            Label_About.Font = new Font("NT Somic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_About.ForeColor = SystemColors.ControlDark;
            Label_About.Location = new Point(22, 53);
            Label_About.Name = "Label_About";
            Label_About.Size = new Size(200, 18);
            Label_About.TabIndex = 11;
            Label_About.Text = "building materials store";
            // 
            // Label_Company
            // 
            Label_Company.AutoSize = true;
            Label_Company.BackColor = Color.Transparent;
            Label_Company.Font = new Font("NT Somic Semibold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Label_Company.ForeColor = SystemColors.Control;
            Label_Company.Location = new Point(21, 29);
            Label_Company.Name = "Label_Company";
            Label_Company.Size = new Size(117, 20);
            Label_Company.TabIndex = 11;
            Label_Company.Text = "BLUEPRINT";
            // 
            // Btn_Logout
            // 
            Btn_Logout.BackColor = Color.Transparent;
            Btn_Logout.BorderWidth = 0;
            Btn_Logout.ForeColor = Color.FromArgb(96, 103, 110);
            Btn_Logout.Icon = (Image)resources.GetObject("Btn_Logout.Icon");
            Btn_Logout.IconInactive = (Image)resources.GetObject("Btn_Logout.IconInactive");
            Btn_Logout.Location = new Point(18, 760);
            Btn_Logout.Name = "Btn_Logout";
            Btn_Logout.Padding = new Padding(12);
            Btn_Logout.Size = new Size(284, 51);
            Btn_Logout.Style = ButtonIcon.Styles.Inactive;
            Btn_Logout.TabIndex = 11;
            Btn_Logout.TextContent = "Выйти";
            // 
            // panelRound1
            // 
            panelRound1.BackColor = Color.FromArgb(19, 20, 21);
            panelRound1.Controls.Add(button1);
            panelRound1.Controls.Add(Label_About);
            panelRound1.Controls.Add(Label_Company);
            panelRound1.Location = new Point(18, 569);
            panelRound1.Name = "panelRound1";
            panelRound1.Padding = new Padding(18);
            panelRound1.Size = new Size(284, 170);
            panelRound1.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(38, 41, 43);
            button1.ButtonSize = new Size(242, 52);
            button1.ForeColor = Color.FromArgb(224, 233, 241);
            button1.Location = new Point(21, 97);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(242, 52);
            button1.Style = Button.Styles.Light;
            button1.TabIndex = 12;
            button1.TextContent = "+  создать пользователя";
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelRound1);
            Controls.Add(Btn_Logout);
            Controls.Add(Nav_Clients);
            Controls.Add(Nav_Orders);
            Controls.Add(Nav_Create);
            Controls.Add(Nav_Products);
            Controls.Add(Lable_Usertype);
            Controls.Add(Label_Username);
            Controls.Add(Avatar);
            Name = "Sidebar";
            Padding = new Padding(15);
            Size = new Size(320, 829);
            panelRound1.ResumeLayout(false);
            panelRound1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AcrylicUI.Controls.AcrylicPanel Avatar;
        private Label Label_Username;
        private Label Lable_Usertype;
        private ButtonIcon Nav_Products;
        private ButtonIcon Nav_Create;
        private ButtonIcon Nav_Orders;
        private ButtonIcon Nav_Clients;
        private Label Label_Company;
        private Label Label_About;
        private ButtonIcon Btn_Logout;
        private PanelRound panelRound1;
        private Button button1;
    }
}
