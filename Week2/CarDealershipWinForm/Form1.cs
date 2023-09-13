using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealershipWinForm
{
    public partial class Form1 : Form
    {
        Dealership _dealership = new Dealership();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach(Car car in _dealership.GetAllCars())
            {
                textBox1.Text += car.ToString() + "\r\n";
            }
        }

        private void makeBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (Car car in _dealership.GetAllCarsByMake("Ford"))
            {
                textBox1.Text += car.ToString() + "\r\n";
            }
        }

        private void fuelBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text += _dealership.GetCarWithBestMileage().ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
