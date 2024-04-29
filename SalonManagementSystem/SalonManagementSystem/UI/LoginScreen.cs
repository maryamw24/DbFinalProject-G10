using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonManagementSystem.DbConfiguration;
using System.Data.SqlClient;

namespace SalonManagementSystem.UI
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //verifyUser();
            Form1 f= new Form1();
            f.Show();
        }

        private void verifyUser()
        {
            int count = 0;
            string w_username = usernameTxt.Text;
            string w_password = passwordTxt.Text;
            int id;
            string password = "";
            int role = -1;
            string query = $"Select personid, password, role From Employee Where username = '{w_username}'";
            var con = Configuration.getInstance().getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = (int)reader["personId"];
                    password = reader["password"].ToString();
                    role = (int)reader["role"];
                    count = 1;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            if (count == 0)
            {
                MessageBox.Show("User name doesnot exists.");
            }
            else if (w_password != password)
            {
                MessageBox.Show("Incorrect password. Try again with correct password.");
            }
            else if (password == w_password)
            {
                if(role == 3)
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
        }
    }
}
