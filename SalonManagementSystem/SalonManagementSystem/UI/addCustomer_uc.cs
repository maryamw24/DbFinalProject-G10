using SalonManagementSystem.Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonManagementSystem.DbConfiguration;


namespace SalonManagementSystem.UI
{
    public partial class addCustomer_uc : UserControl
    {
        private Dictionary<string, List<string>> pakistanProvinceCityMap = new Dictionary<string, List<string>>
        {
            {"Punjab", new List<string>{"Lahore", "Faisalabad", "Rawalpindi", "Multan"}},
            {"Sindh", new List<string>{"Karachi", "Hyderabad", "Sukkur", "Larkana"}},
            {"Khyber Pakhtunkhwa", new List<string>{"Peshawar", "Abbottabad", "Swat", "Mardan"}},
            {"Balochistan", new List<string>{"Quetta", "Gwadar", "Khuzdar", "Turbat"}},
            {"Gilgit-Baltistan", new List<string>{"Gilgit", "Skardu", "Hunza", "Ghizer"}},
            {"Azad Kashmir", new List<string>{"Muzaffarabad", "Mirpur", "Kotli", "Rawalakot"}}
        };
        public addCustomer_uc()
        {
            InitializeComponent();
            LoadProvinces();
            privinceCombobox.SelectedIndexChanged += privinceCombobox_SelectedIndexChanged;
        }
        private void LoadProvinces()
        {
            foreach (string province in pakistanProvinceCityMap.Keys)
            {
                privinceCombobox.Items.Add(province);
            }
        }
        private void privinceCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboBox.Items.Clear();
            string selectedProvince = privinceCombobox.SelectedItem.ToString();
            List<string> cities = pakistanProvinceCityMap[selectedProvince];
            foreach (string city in cities)
            {
                cityComboBox.Items.Add(city);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Customer customer = createObject();
            addCustomer(customer);
        }

        private Customer createObject()
        {
            Customer customer = new Customer();
            customer.Name = fulllNameTxt.Text;
            customer.Email = emailTxt.Text;
            customer.Address = streeAddressTxt.Text + " " + cityComboBox.SelectedItem.ToString() + privinceCombobox.SelectedItem.ToString();
            customer.Phone = phoneTxt.Text;
            if (maleRBtn.Checked)
            {
                customer.gender = "Male";
            }
            if (femaleRBtn.Checked)
            {
                customer.gender = "Female";
            }
            return customer;
        }

        private void addCustomer(Customer c)
        {
            string query = $"EXEC stpAddCustomer '{c.Name}', '{c.Email}', '{c.Address}', '{c.Phone}',{c.gender}, 2, '{c.createdOn}'";
            var connection = Configuration.getInstance().getConnection();
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully");
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
            
        }

        private void clear()
        {
            fulllNameTxt.Text = "";
            emailTxt.Text = "";
            streeAddressTxt.Text = "";
            phoneTxt.Text = "";
            maleRBtn.Checked = false;
            femaleRBtn.Checked = false;
            cityComboBox.SelectedIndex = -1;
            privinceCombobox.SelectedIndex = -1;
        }
    }

}
