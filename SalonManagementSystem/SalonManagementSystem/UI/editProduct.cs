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
    public partial class editProduct : UserControl
    {
        public editProduct()
        {
            InitializeComponent();
        }

        private void emp_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2) {
                Action f1 = new Action();
                popupForm f = new popupForm();
                Panel p = f1.GetMainPanel();
                f.Add(f1, p);
                f.Show();
            }
            

        }
    }
}
