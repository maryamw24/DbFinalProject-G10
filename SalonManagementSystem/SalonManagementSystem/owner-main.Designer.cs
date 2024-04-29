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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.home = new Guna.UI2.WinForms.Guna2Button();
            this.serviceSection = new Guna.UI2.WinForms.Guna2Button();
            this.productSection = new Guna.UI2.WinForms.Guna2Button();
            this.employeeSection = new Guna.UI2.WinForms.Guna2Button();
            this.customerSection = new Guna.UI2.WinForms.Guna2Button();
            this.logOut = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 92);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.28159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.71841F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.71831F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.28169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1464, 92);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.panel3.Controls.Add(this.home);
            this.panel3.Controls.Add(this.serviceSection);
            this.panel3.Controls.Add(this.productSection);
            this.panel3.Controls.Add(this.employeeSection);
            this.panel3.Controls.Add(this.customerSection);
            this.panel3.Controls.Add(this.logOut);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(168, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1293, 55);
            this.panel3.TabIndex = 1;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.home.BorderColor = System.Drawing.Color.White;
            this.home.Checked = true;
            this.home.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.home.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.home.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.home.CustomBorderColor = System.Drawing.Color.Transparent;
            this.home.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.home.Dock = System.Windows.Forms.DockStyle.Right;
            this.home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.home.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.home.HoverState.BorderColor = System.Drawing.Color.White;
            this.home.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.home.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.home.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.home.Location = new System.Drawing.Point(213, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(180, 55);
            this.home.TabIndex = 5;
            this.home.Text = "Home";
            // 
            // serviceSection
            // 
            this.serviceSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.serviceSection.BorderColor = System.Drawing.Color.Transparent;
            this.serviceSection.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.serviceSection.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.serviceSection.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.serviceSection.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.serviceSection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.serviceSection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.serviceSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.serviceSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.serviceSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.serviceSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.serviceSection.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.serviceSection.HoverState.BorderColor = System.Drawing.Color.White;
            this.serviceSection.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.serviceSection.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.serviceSection.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.serviceSection.Location = new System.Drawing.Point(393, 0);
            this.serviceSection.Name = "serviceSection";
            this.serviceSection.Size = new System.Drawing.Size(180, 55);
            this.serviceSection.TabIndex = 4;
            this.serviceSection.Text = "Service";
            this.serviceSection.Click += new System.EventHandler(this.serviceSection_Click);
            // 
            // productSection
            // 
            this.productSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.productSection.BorderColor = System.Drawing.Color.Transparent;
            this.productSection.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.productSection.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.productSection.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.productSection.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.productSection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productSection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.productSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.productSection.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.productSection.HoverState.BorderColor = System.Drawing.Color.White;
            this.productSection.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.productSection.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.productSection.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.productSection.Location = new System.Drawing.Point(573, 0);
            this.productSection.Name = "productSection";
            this.productSection.Size = new System.Drawing.Size(180, 55);
            this.productSection.TabIndex = 3;
            this.productSection.Text = "Products";
            this.productSection.Click += new System.EventHandler(this.productSection_Click);
            // 
            // employeeSection
            // 
            this.employeeSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.employeeSection.BorderColor = System.Drawing.Color.Transparent;
            this.employeeSection.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.employeeSection.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.employeeSection.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.employeeSection.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.employeeSection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.employeeSection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.employeeSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.employeeSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.employeeSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.employeeSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.employeeSection.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.employeeSection.HoverState.BorderColor = System.Drawing.Color.White;
            this.employeeSection.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.employeeSection.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.employeeSection.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.employeeSection.Location = new System.Drawing.Point(753, 0);
            this.employeeSection.Name = "employeeSection";
            this.employeeSection.Size = new System.Drawing.Size(180, 55);
            this.employeeSection.TabIndex = 2;
            this.employeeSection.Text = "Employees";
            // 
            // customerSection
            // 
            this.customerSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.customerSection.BorderColor = System.Drawing.Color.Transparent;
            this.customerSection.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.customerSection.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.customerSection.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.customerSection.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.customerSection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerSection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.customerSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.customerSection.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.customerSection.HoverState.BorderColor = System.Drawing.Color.White;
            this.customerSection.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.customerSection.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.customerSection.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.customerSection.Location = new System.Drawing.Point(933, 0);
            this.customerSection.Name = "customerSection";
            this.customerSection.Size = new System.Drawing.Size(180, 55);
            this.customerSection.TabIndex = 1;
            this.customerSection.Text = "Customers";
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.Transparent;
            this.logOut.BorderColor = System.Drawing.Color.Transparent;
            this.logOut.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.logOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.logOut.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.logOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.logOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.logOut.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.logOut.HoverState.BorderColor = System.Drawing.Color.White;
            this.logOut.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.logOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.logOut.Location = new System.Drawing.Point(1113, 0);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(180, 55);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Log Out";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1464, 86);
            this.panel2.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 92);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1464, 520);
            this.panelChildForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 698);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button serviceSection;
        private Guna.UI2.WinForms.Guna2Button productSection;
        private Guna.UI2.WinForms.Guna2Button employeeSection;
        private Guna.UI2.WinForms.Guna2Button customerSection;
        private Guna.UI2.WinForms.Guna2Button logOut;
        private Guna.UI2.WinForms.Guna2Button home;
    }
}

