using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11InClassDemo.ADOnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// create the data connection for SQL Authentication
            string connectionString = "server=.\\SQLEXPRESS;Database=Northwind2;User Id=sa;Password=Password01!";

            ////IF USING WINDOWS AUTH, then connection string should be something like this:
            //string connectionStringWindowsAuth = "server=.\\SQLEXPRESS;Trusted_Connection=yes;database=Northwind2";

            // create the string to hold the SQL command 
            // to get records from the Customers table
            string commandString = "Select OrderDate, ShippedDate from Orders";

            // create the data adapter with the connection string and command
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(commandString, connectionString);

            // Create and fill the DataSet object
            DataSet myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet);

            // Retrieve the Orders table
            DataTable myDataTable = myDataSet.Tables[0];

            // iterate over the rows collection and output the fields
            foreach (DataRow dataRow in myDataTable.Rows)
            {
                Console.WriteLine("Order Date: {0}. Shipped Date: {1}", dataRow["OrderDate"], dataRow["ShippedDate"]);
            }

            Console.ReadLine();

        }
    }
}
