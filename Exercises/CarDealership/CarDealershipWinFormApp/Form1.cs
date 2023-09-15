using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealershipConsoleApp;


namespace CarDealershipWinFormApp
{
    public partial class Form1 : Form
    {
        Dealership dealership;
        public Form1()
        {
            InitializeComponent();
            dealership = new Dealership();
        }

        public void DisplayListAllCars(object sender, EventArgs e)
        {
            outputBox.Text = string.Empty;
            foreach (Car c in dealership.GetAllCars())
            {
                outputBox.Text += c.ToString() + "\r\n";
            }
        }

        public void DisplayBestMileageCar(object sender, EventArgs e)
        {
            outputBox.Text = string.Empty;
            Car car = dealership.GetBestMileageCar();
            outputBox.Text = car.ToString() + "\r\n"; ;
        }

        public void DisplayCarByMake(object sender, EventArgs e)
        {
            outputBox.Text = string.Empty;
            foreach (Car c in dealership.GetCarByMake("Ford"))
            {
                if (c != null && c.ToString() != string.Empty)
                {
                    outputBox.Text += c.ToString() + "\r\n"; ;
                }
            }
        }

        public void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
