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
    public partial class retrunProduct : UserControl
    {
        private const string PlaceholderText = "Description";
        public retrunProduct()
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
        public Panel GetMainPanel()
        {
            return mainpanel;
        }
    }
}
