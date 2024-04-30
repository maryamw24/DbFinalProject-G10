using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonManagementSystem.UI
{
    public partial class Action : UserControl
    {
        public Action()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public Panel GetMainPanel()
        {
            return mainpanel;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             orderProduct f1 = new orderProduct();
            popupForm f = new popupForm();
            Panel p = f1.GetMainPanel();
            f.Add(f1, p);
            f.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {

                // Create the returnProduct form and show it
                retrunProduct f1 = new retrunProduct();
                popupForm f = new popupForm();
                Panel p = f1.GetMainPanel();
                f.Add(f1, p);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Action f = new Action();
            f.Hide();
            MessageBox.Show("one");
            /*discardProduct f1 = new discardProduct();
            popupForm f = new popupForm();
            Panel p = f1.GetMainPanel();
            f.Add(f1, p);
            f.Show();*/

        }
    }
}
