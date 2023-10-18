using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6InClassDemo.Checkboxes
{
    public partial class Checkboxes : Form
    {
        public Checkboxes()
        {
            InitializeComponent();
        }

        public void Show_Clicked(object sender, EventArgs e)
        {
            int totalChecked = 0;
            if (checkBox1.Checked)
                totalChecked++;
            if (checkBox2.Checked)
                totalChecked++;
            if (checkBox3.Checked)
                totalChecked++;
            if (checkBox4.Checked)
                totalChecked++;

            MessageBox.Show($"You have checked {totalChecked} boxes");
        }

        public void Show_WithLinq(object sender, EventArgs e)
        {
            var totalChecked = checkboxGroup.Controls
                                            .OfType<CheckBox>()
                                            .Where(c => c.Checked)
                                            .Count();


            MessageBox.Show($"You have checked {totalChecked} boxes");
        }

        public void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
