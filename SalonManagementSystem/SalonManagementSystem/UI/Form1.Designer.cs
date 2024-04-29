namespace SalonManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_tablepanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.navbar_panel = new System.Windows.Forms.Panel();
            this.home_btn = new Guna.UI2.WinForms.Guna2Button();
            this.services_btn = new Guna.UI2.WinForms.Guna2Button();
            this.products_btn = new Guna.UI2.WinForms.Guna2Button();
            this.employees_btn = new Guna.UI2.WinForms.Guna2Button();
            this.customers_btn = new Guna.UI2.WinForms.Guna2Button();
            this.notifications_btn = new Guna.UI2.WinForms.Guna2Button();
            this.reports_btn = new Guna.UI2.WinForms.Guna2Button();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.main_tablepanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.navbar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tablepanel
            // 
            this.main_tablepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.main_tablepanel.ColumnCount = 1;
            this.main_tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tablepanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.main_tablepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tablepanel.Location = new System.Drawing.Point(0, 0);
            this.main_tablepanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.main_tablepanel.Name = "main_tablepanel";
            this.main_tablepanel.RowCount = 2;
            this.main_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.main_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.main_tablepanel.Size = new System.Drawing.Size(1788, 965);
            this.main_tablepanel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.825729F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.17427F));
            this.tableLayoutPanel1.Controls.Add(this.navbar_panel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.43231F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.03729F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1782, 117);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // navbar_panel
            // 
            this.navbar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.navbar_panel.Controls.Add(this.home_btn);
            this.navbar_panel.Controls.Add(this.services_btn);
            this.navbar_panel.Controls.Add(this.products_btn);
            this.navbar_panel.Controls.Add(this.employees_btn);
            this.navbar_panel.Controls.Add(this.customers_btn);
            this.navbar_panel.Controls.Add(this.notifications_btn);
            this.navbar_panel.Controls.Add(this.reports_btn);
            this.navbar_panel.Controls.Add(this.logout_btn);
            this.navbar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navbar_panel.Location = new System.Drawing.Point(160, 18);
            this.navbar_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navbar_panel.Name = "navbar_panel";
            this.navbar_panel.Size = new System.Drawing.Size(1619, 76);
            this.navbar_panel.TabIndex = 2;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.home_btn.BorderColor = System.Drawing.Color.White;
            this.home_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.home_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.home_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.home_btn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.home_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.home_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.home_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.home_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.home_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.home_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.home_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.home_btn.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.home_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.home_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.home_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.home_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.home_btn.Location = new System.Drawing.Point(3, 0);
            this.home_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(202, 76);
            this.home_btn.TabIndex = 7;
            this.home_btn.Text = "Home";
            // 
            // services_btn
            // 
            this.services_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.services_btn.BorderColor = System.Drawing.Color.White;
            this.services_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.services_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.services_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.services_btn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.services_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.services_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.services_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.services_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.services_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.services_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.services_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.services_btn.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.services_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.services_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.services_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.services_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.services_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.services_btn.Location = new System.Drawing.Point(205, 0);
            this.services_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.services_btn.Name = "services_btn";
            this.services_btn.Size = new System.Drawing.Size(202, 76);
            this.services_btn.TabIndex = 6;
            this.services_btn.Text = "Services";
            // 
            // products_btn
            // 
            this.products_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.products_btn.BorderColor = System.Drawing.Color.White;
            this.products_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.products_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.products_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.products_btn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.products_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.products_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.products_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.products_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.products_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.products_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.products_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.products_btn.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.products_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.products_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.products_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.products_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.products_btn.Location = new System.Drawing.Point(407, 0);
            this.products_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.products_btn.Name = "products_btn";
            this.products_btn.Size = new System.Drawing.Size(202, 76);
            this.products_btn.TabIndex = 5;
            this.products_btn.Text = "Products";
            this.products_btn.Click += new System.EventHandler(this.products_btn_Click_1);
            // 
            // employees_btn
            // 
            this.employees_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.employees_btn.BorderColor = System.Drawing.Color.Transparent;
            this.employees_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.employees_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.employees_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.employees_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.employees_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.employees_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.employees_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.employees_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.employees_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.employees_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.employees_btn.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employees_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.employees_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.employees_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.employees_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.employees_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.employees_btn.Location = new System.Drawing.Point(609, 0);
            this.employees_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employees_btn.Name = "employees_btn";
            this.employees_btn.Size = new System.Drawing.Size(202, 76);
            this.employees_btn.TabIndex = 4;
            this.employees_btn.Text = "Employees";
            this.employees_btn.Click += new System.EventHandler(this.employees_btn_Click_1);
            // 
            // customers_btn
            // 
            this.customers_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.customers_btn.BorderColor = System.Drawing.Color.Transparent;
            this.customers_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.customers_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.customers_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.customers_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.customers_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customers_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customers_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customers_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customers_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.customers_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.customers_btn.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.customers_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.customers_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.customers_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.customers_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.customers_btn.Location = new System.Drawing.Point(811, 0);
            this.customers_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(202, 76);
            this.customers_btn.TabIndex = 3;
            this.customers_btn.Text = "Customers";
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click_1);
            // 
            // notifications_btn
            // 
            this.notifications_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.notifications_btn.BorderColor = System.Drawing.Color.Transparent;
            this.notifications_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.notifications_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.notifications_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.notifications_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.notifications_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notifications_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notifications_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notifications_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notifications_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.notifications_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.notifications_btn.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifications_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.notifications_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.notifications_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.notifications_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.notifications_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.notifications_btn.Location = new System.Drawing.Point(1013, 0);
            this.notifications_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notifications_btn.Name = "notifications_btn";
            this.notifications_btn.Size = new System.Drawing.Size(202, 76);
            this.notifications_btn.TabIndex = 2;
            this.notifications_btn.Text = "Notifications";
            this.notifications_btn.Click += new System.EventHandler(this.notifications_btn_Click);
            // 
            // reports_btn
            // 
            this.reports_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.reports_btn.BorderColor = System.Drawing.Color.Transparent;
            this.reports_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.reports_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.reports_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.reports_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.reports_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reports_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reports_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reports_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reports_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.reports_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.reports_btn.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.reports_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.reports_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.reports_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.reports_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.reports_btn.Location = new System.Drawing.Point(1215, 0);
            this.reports_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reports_btn.Name = "reports_btn";
            this.reports_btn.Size = new System.Drawing.Size(202, 76);
            this.reports_btn.TabIndex = 1;
            this.reports_btn.Text = "Reports";
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.BorderColor = System.Drawing.Color.Transparent;
            this.logout_btn.BorderRadius = 12;
            this.logout_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.logout_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.logout_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.logout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.logout_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.logout_btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.logout_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.logout_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.logout_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.logout_btn.Location = new System.Drawing.Point(1417, 0);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(202, 76);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Text = "Log Out";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 965);
            this.Controls.Add(this.main_tablepanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.main_tablepanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.navbar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel main_tablepanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel navbar_panel;
        private Guna.UI2.WinForms.Guna2Button home_btn;
        private Guna.UI2.WinForms.Guna2Button services_btn;
        private Guna.UI2.WinForms.Guna2Button products_btn;
        private Guna.UI2.WinForms.Guna2Button employees_btn;
        private Guna.UI2.WinForms.Guna2Button customers_btn;
        private Guna.UI2.WinForms.Guna2Button notifications_btn;
        private Guna.UI2.WinForms.Guna2Button reports_btn;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
    }
}

