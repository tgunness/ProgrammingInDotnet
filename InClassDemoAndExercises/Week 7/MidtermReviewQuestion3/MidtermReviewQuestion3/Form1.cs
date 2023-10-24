using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermReviewQuestion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bookRoomButton_Click(object sender, EventArgs e)
        {
            int cost = 0;

            if (i102RadioButton.Checked || i110RadioButton.Checked)
            {
                
                if(monthCalendar.SelectionStart.DayOfWeek == DayOfWeek.Monday ||
                    monthCalendar.SelectionStart.DayOfWeek == DayOfWeek.Tuesday)
                {
                    cost = 10;
                }
                else
                {
                    cost = 5;
                }
            }
            else if (a123RadioButton.Checked)
            {
                cost = 7;
            }
            else
            {
                cost = 0;
            }


            costLabel.Text = $"Cost: ${cost}";

        }
    }
}
