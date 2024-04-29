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
    public partial class popupForm : Form
    {
        private System.Windows.Forms.UserControl userControl;

        public popupForm()
        {
            InitializeComponent();
        }

        private void popupForm_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Add(UserControl userControl, Panel p)
        {
            userControl.Dock = DockStyle.Fill;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(p);
            userControl.BringToFront();
        }
    }
}
