using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // code to open a chilf form into a panel //
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        // Button Functions //
        private void serviceSection_Click(object sender, EventArgs e)
        {
            uncheckedButtons();
            serviceSection.Checked = true;
            Service_Section service_Section = new Service_Section();
            OpenChildForm(service_Section);

        }


        // Ui Customization Funcitons //

        private void uncheckedButtons()
        {
            serviceSection.Checked = false;
            employeeSection.Checked = false;
            customerSection.Checked = false;
            productSection.Checked = false;
            home.Checked = false;
        }

        private void productSection_Click(object sender, EventArgs e)
        {

        }
    }
}
