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
    public partial class addProduct : UserControl
    {
        private const string PlaceholderText = "Description";

        public addProduct()
        {
            InitializeComponent();
            InitializeRichTextBox();
            richTextBox1.Enter += richTextBox1_Enter;
            richTextBox1.Leave += richTextBox1_Leave;
        }


        private void InitializeRichTextBox()
        {
            richTextBox1.Text = PlaceholderText;
            richTextBox1.ForeColor = System.Drawing.Color.Gray;
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                richTextBox1.Text = PlaceholderText;
                richTextBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == PlaceholderText)
            {
                richTextBox1.Clear();
                richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            addSupplier f1 = new addSupplier();
            popupForm f = new popupForm();
            Panel p = f1.GetMainPanel();
            f.Add(f1, p);
            f.Show();


        }

        private void company_Click(object sender, EventArgs e)
        {
            addCompany f1 = new addCompany();
            popupForm f = new popupForm();
            Panel p = f1.GetMainPanel();
            f.Add(f1, p);
            f.Show();

        }

        private void producttype_Click(object sender, EventArgs e)
        {
            addPoductType f1 = new addPoductType();
            popupForm f = new popupForm();
            Panel p = f1.GetMainPanel();
            f.Add(f1, p);
            f.Show();

        }
    }
}
