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
        public void RemoveAllControlsFromOuterPanel(TableLayoutPanel panel)
        {

                Control control = panel.GetControlFromPosition(0, 1);
                if (control != null)
                {
                    panel.Controls.Remove(control);
                    control.Dispose();
                }
        }
        private void AddButtonsToDropdownPanel(Panel panel, params string[] buttonLabels)
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
                panel.Controls.Add(button);
            }
        }






        private void employees_btn_Click(object sender, EventArgs e)
        {
            RemoveAllControlsFromOuterPanel(main_tablepanel);

            center_uc center = new center_uc();
            center.Dock = DockStyle.Fill;

            main_tablepanel.Controls.Add(center);

            AddButtonsToDropdownPanel(center.DropdownPanel, "Employee Atendance", "Employee Salary", "Employee Personal Details");

            RemoveAllControlsFromOuterPanel(center.OuterTablePanel);

            // Create and add employees_uc to the first row of outer_panel
            employees_uc employeesUC = new employees_uc();
            employeesUC.Dock = DockStyle.Fill;
            center.OuterTablePanel.Controls.Add(employeesUC, 0, 1); 
        }
    }
}
