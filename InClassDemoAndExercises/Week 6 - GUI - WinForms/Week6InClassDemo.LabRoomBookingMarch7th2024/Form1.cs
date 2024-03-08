using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string _selectedRoom;
        public Form1()
        {
            InitializeComponent();
            _selectedRoom = "";

            List<Class1> list = new List<Class1>()
            {
                new Class1{ name = "trishan"},
                new Class1{ name = "jason"},
                new Class1{ name = "pam"},

            };

            listBox1.Items.AddRange(list.ToArray());
        }

        private void bookRoomBtn_Click(object sender, EventArgs e)
        {
            string FirstName = firstNameTextbox.Text;
            string LastName = lastNameTextBox.Text;
            string BookedDateTime = bookingCalendar.SelectionStart.ToString();
            string SelectedRoom = GetSelectionRadio();//_selectedRoom;

            //string SelectedRoom = roomGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

            string output = $"Thank you! Lab {SelectedRoom} booked on {BookedDateTime} for {FirstName} {LastName}";
            outputLabel.Text = output;
            outputLabel.Visible = true;
            MessageBox.Show(output, "Booked!!!", MessageBoxButtons.OK);

            Class1 selected = (Class1)listBox1.SelectedItem;

            MessageBox.Show(selected.ToString());

        }

        private void i102_CheckedChanged(object sender, EventArgs e)
        {
            _selectedRoom = "i102";
        }

        private void a123_CheckedChanged(object sender, EventArgs e)
        {
            _selectedRoom = "a123";
        }

        private void i110_CheckedChanged(object sender, EventArgs e)
        {
            _selectedRoom = "i110";
        }


        private string GetSelectionRadio()
        {
            foreach(var control in roomGroupBox.Controls)
            {
                if(control is RadioButton)
                {
                    RadioButton temp = (RadioButton)control;
                    if (temp.Checked)
                        return temp.Text;
                }
            }
            return "";
        }
    }
}
