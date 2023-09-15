using System;
using System.Windows.Forms;
using CarDealershipCommon;

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

        public void DisplayAllCars(object sender, EventArgs e)
        {
            outputBox.Text = "";
            foreach (Car c in dealership.GetAllCars())
            {
                if (c != null)
                {
                    outputBox.Text += c.ToString();
                    outputBox.Text += Environment.NewLine;
                }
            }
        }

        public void DisplayBestMileage(object sender, EventArgs e)
        {
            Car c = dealership.GetBestMileageCar();
            outputBox.Text = "";
            outputBox.Text += c.ToString();
        }

        public void DisplayMake(object sender, EventArgs e)
        {
            outputBox.Text = "";
            foreach (Car c in dealership.GetCarByMake("Ford"))
            {
                if (c != null)
                {
                    outputBox.Text += c.ToString();
                    outputBox.Text += Environment.NewLine;
                }
            }
        }

        public void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
