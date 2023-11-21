using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11InClassDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwind2DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwind2DataSet.Customers);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                customersTableAdapter.Insert(customerIDTextBox.Text,
                    companyNameTextBox.Text, 
                    contactNameTextBox.Text, 
                    contactTitleTextBox.Text, 
                    addressTextBox.Text, 
                    cityTextBox.Text, 
                    regionTextBox.Text, 
                    postalCodeTextBox.Text, 
                    countryTextBox.Text, 
                    phoneTextBox.Text, 
                    faxTextBox.Text);
                this.customersTableAdapter.Fill(this.northwind2DataSet.Customers);
            }
            catch (SqlException exception)
            {
                MessageBox.Show($"Try Again! error {exception.Message}");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach(var control in customerDetailGroup.Controls.OfType<TextBox>().ToList())
            {
                control.Text = "";
            }
        }

        private void customerDetailGroup_Enter(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            customersTableAdapter.Delete(customerIDTextBox.Text,
                    companyNameTextBox.Text,
                    contactNameTextBox.Text,
                    contactTitleTextBox.Text,
                    addressTextBox.Text,
                    cityTextBox.Text,
                    regionTextBox.Text,
                    postalCodeTextBox.Text,
                    countryTextBox.Text,
                    phoneTextBox.Text,
                    faxTextBox.Text);
        }
    }
}
