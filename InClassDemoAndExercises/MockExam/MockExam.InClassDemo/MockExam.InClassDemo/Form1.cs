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

namespace MockExam.InClassDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwind2DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwind2DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northwind2DataSet.Orders);
            // TODO: This line of code loads data into the 'northwind2DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northwind2DataSet.Orders);
            // TODO: This line of code loads data into the 'northwind2DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwind2DataSet.Customers);

        }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=.\\SQLEXPRESS;Database=Northwind2;User Id=sa;Password=Password01!";

            string commandString = "SELECT TOP 1 s.CompanyName " +
                                   "FROM dbo.customers as c " +
                                   "left join dbo.orders as o on o.CustomerID = c.CustomerID " +
                                   "left join dbo.Shippers as s on s.ShipperID = o.ShipVia " +
                                   $"where c.CompanyName = '{customerNameLabel.Text}' " +
                                   "order by orderdate desc";

            // create the data adapter with the connection string and command
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(commandString, connectionString);

            DataSet myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet);

            DataTable myDataTable = myDataSet.Tables[0];
            DataRow row = myDataTable.Rows[0];
            textBox1.Text = row["CompanyName"].ToString();

        }
    }
}
