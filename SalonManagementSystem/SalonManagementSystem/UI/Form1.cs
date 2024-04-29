using Guna.UI2.WinForms;
using SalonManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Control = System.Windows.Forms.Control;

namespace SalonManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button Click Function
        private void employees_btn_Click_1(object sender, EventArgs e)
        {
            center_uc center = addCentre_uc();
            AddButtonsToDropdownPanel(center, "Employee Atendance", "Employee Salary", "Employee Personal Details", "Add Employees");
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            center_uc center = addCentre_uc();
            AddButtonsToDropdownPanel(center, "View Customer Types",  "Add Customer Type", "View Customers", "Add Customer");
        }

        // centre uc customizations
        private center_uc addCentre_uc()
        {
            RemoveAllControlsFromOuterPanel(main_tablepanel);

            center_uc center = new center_uc();
            center.Dock = DockStyle.Fill;

            main_tablepanel.Controls.Add(center);
            return center;
        }
        public void RemoveAllControlsFromOuterPanel(TableLayoutPanel panel)
        {

                Control control = panel.GetControlFromPosition(0, 1);
                if (control != null)
                {
                    panel.Controls.Remove(control);
                    control.Dispose();
                }
        }
 
        private void AddButtonsToDropdownPanel(center_uc center, params string[] buttonLabels)
        {
            foreach (string label in buttonLabels)
            {
                Guna2Button button = new Guna2Button();
                button.Text = label;
                button.Dock = DockStyle.Left;
                button.TextAlign = HorizontalAlignment.Center;
                button.Margin = new Padding(0, 1, 0, 0);
                button.ForeColor = Color.FromArgb(157, 35, 76);
                button.Font = new Font("Tw Cen MT", 14, FontStyle.Regular);
                button.BackColor = Color.Transparent;
                button.FillColor = Color.White;
                button.AutoSize = true;
                button.CustomBorderThickness = new Padding(0,0,0,3);
                button.CustomBorderColor = Color.White;

                //hower state ui design
                button.HoverState.CustomBorderColor = Color.FromArgb(157, 35, 76);
                button.HoverState.FillColor = Color.White;
                //checked state ui design
                button.CheckedState.CustomBorderColor = Color.FromArgb(157, 35, 76);
                button.CheckedState.FillColor = Color.White;
                

                // Event handler for button click
                button.Click += (sender, e) =>
                {
                    // Check which button was clicked
                    if (button.Text == "Employee Salary")
                    {
                        // Perform actions specific to the "Employee Salary" button
                        // For example:
                        MessageBox.Show("Employee Salary button clicked!");
                    }
                    else if (button.Text == "Employee Attendance")
                    {
                        // Perform actions specific to the "Employee Attendance" button
                    }
                    else if (button.Text == "Employee Personal Details")
                    {
                        ShowEmployeeDetailsPage(center);
                    }
                    else if (button.Text == "Add Employees")
                    {
                        ShowAddEmployeePage(center);
                    }
                    else if (button.Text == "Add Customer")
                    {
                        ShowAddCustomerPage(center);
                    }
                    else if (button.Text == "View Customers")
                    {
                        ShowViewCustomerPage(center);
                    }
                    else if (button.Text == "Add Customer Type")
                    {
                        ShowAddCustomerTypePage(center);
                    }
                    else if (button.Text == "View Customer Types")
                    {
                        ShowViewCustomerTypePage(center);
                    }
                    ;

                };
                 center.DropdownPanel.Controls.Add(button);
            }
        }

        private void ShowEmployeeDetailsPage(center_uc center)
        {
            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add employees_uc to the first row of outer_panel
            employees_uc employeesUC = new employees_uc();
            employeesUC.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(employeesUC, 0, 1);
        }
        private void ShowAddEmployeePage(center_uc center)
        {
            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add employees_uc to the first row of outer_panel
            addEmp_uc addUC = new addEmp_uc();
            addUC.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(addUC, 0, 1);
        }

        private void ShowAddCustomerPage(center_uc center)
        {
            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add addCustomer_uc to the first row of outer_panel
            addCustomer_uc addCustomerUC = new addCustomer_uc();
            addCustomerUC.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(addCustomerUC, 0, 1);
        }
        private void ShowViewCustomerPage(center_uc center)
        {
            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add addCustomer_uc to the first row of outer_panel
            viewCustomer_uc vc = new viewCustomer_uc();
            vc.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(vc, 0, 1);
        }
        private void ShowAddCustomerTypePage(center_uc center)
        {
            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add addCustomer_uc to the first row of outer_panel
            addcustomerType_uc addcustomerType_Uc = new addcustomerType_uc();
            addcustomerType_Uc.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(addcustomerType_Uc, 0, 1);
        }
        private void ShowViewCustomerTypePage(center_uc center)
        {
            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add addCustomer_uc to the first row of outer_panel
            viewCustomerType_uc vc = new viewCustomerType_uc();
            vc.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(vc, 0, 1);
        }
        private void notifications_btn_Click(object sender, EventArgs e)
        {
            RemoveAllControlsFromOuterPanel(main_tablepanel);
            notifications_uc notify = new notifications_uc();
            notify.Dock = DockStyle.Fill;

            main_tablepanel.Controls.Add(notify);
        }

        private void customers_btn_Click_1(object sender, EventArgs e)
        {
            center_uc center = addCentre_uc();
            AddButtonsToDropdownPanel(center, "View Customer Types", "Add Customer Type", "View Customers", "Add Customer");
        }
        /* Product section*/
        private void products_btn_Click(object sender, EventArgs e)
        {
           
        }
        private void addButtonsForProduct(center_uc center, params string[] buttonLabels)
        {
            foreach (string label in buttonLabels)
            {
                Guna2Button button = new Guna2Button();
                button.Text = label;
                button.Dock = DockStyle.Left;
                button.TextAlign = HorizontalAlignment.Center;
                button.Margin = new Padding(0, 1, 0, 0);
                button.ForeColor = Color.FromArgb(157, 35, 76);
                button.Font = new Font("Tw Cen MT", 14, FontStyle.Regular);
                button.BackColor = Color.Transparent;
                button.FillColor = Color.White;
                button.AutoSize = true;
                button.CustomBorderThickness = new Padding(0, 0, 0, 3);
                button.CustomBorderColor = Color.White;

                //hower state ui design
                button.HoverState.CustomBorderColor = Color.FromArgb(157, 35, 76);
                button.HoverState.FillColor = Color.White;
                //checked state ui design
                button.CheckedState.CustomBorderColor = Color.FromArgb(157, 35, 76);
                button.CheckedState.FillColor = Color.White;


                // Event handler for button click
                button.Click += (sender, e) =>
                {
                    // Check which button was clicked
                    if (button.Text == "Add Company")
                    {
                        showAddCompany(center);
                    }
                    else if (button.Text == "Add Product")
                    {
                        showAddProduct(center);
                    }
                    else if (button.Text == "Add Product Type")
                    {
                        showAddProductType(center);
                    }
                    else if (button.Text == "Add Supplier")
                    {
                        showAddSupplier(center);
                    };

                };
                center.DropdownPanel.Controls.Add(button);
            }


        }

        private void showAddProduct(center_uc center)
        {
            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add employees_uc to the first row of outer_panel
            addProduct employeesUC = new addProduct();
            employeesUC.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(employeesUC, 0, 1);
        }

        private void showAddSupplier(center_uc center)
        {
            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add employees_uc to the first row of outer_panel
            addSupplier employeesUC = new addSupplier();
            employeesUC.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(employeesUC, 0, 1);
        }

        private void showAddCompany(center_uc center)
        {
            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add employees_uc to the first row of outer_panel
            addCompany employeesUC = new addCompany();
            employeesUC.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(employeesUC, 0, 1);

        }
        private void showAddProductType(center_uc center)
        {
            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add employees_uc to the first row of outer_panel
            addPoductType employeesUC = new addPoductType();
            employeesUC.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(employeesUC, 0, 1);

        }

        private void products_btn_Click_1(object sender, EventArgs e)
        {
            RemoveAllControlsFromOuterPanel(main_tablepanel);

            center_uc center = new center_uc();
            center.Dock = DockStyle.Fill;

            main_tablepanel.Controls.Add(center);

            addButtonsForProduct(center, "Add Product Type", "Add Company", "Add Supplier", "Add Product");



        }
    }
}
