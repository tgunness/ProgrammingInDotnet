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

namespace MyMockSolutionWinFormQuestion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northWind3DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northWind3DataSet.Orders);
            // TODO: This line of code loads data into the 'northWind3DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northWind3DataSet.Customers);
            shipViaTextBox.Visible = false;
        }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            string shipperID = shipViaTextBox.Text;

            if (string.IsNullOrEmpty(shipperID))
            {
                notesTextBox.Text = "";
                    return;
            }    
                

            string connectionString = "server=.\\SQLEXPRESS;Database=Northwind3;User Id=sa;Password=Password01!";

            string sqlString = $"SELECT * FROM dbo.Shippers WHERE ShipperId = {shipperID}";

            //notesTextBox.Text = sqlString;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlString, connectionString);

            DataSet myDataSet = new DataSet();
            sqlDataAdapter.Fill(myDataSet);

            DataTable myDataTable = myDataSet.Tables[0];

            DataRow dataRow = myDataTable.Rows[0];

            notesTextBox.Text = dataRow["CompanyName"].ToString();
        }
    }
}
