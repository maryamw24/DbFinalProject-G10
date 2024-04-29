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
    public partial class Service_Section : Form
    {
        public Service_Section()
        {
            InitializeComponent();
        }

        private void uncheckButtons()
        {
            addService.Checked = false;
            viewService.Checked = false;
        }

        private void viewService_Click(object sender, EventArgs e)
        {
            uncheckButtons();
            viewService.Checked = true;
        }

        private void addService_Click(object sender, EventArgs e)
        {
            uncheckButtons();
            addService.Checked = true;
        }
    }
}
