using System;
using System.Windows.Forms;

namespace Week6Demo
{
    public partial class Form1 : Form
    {
        private BookingViewModel booking;

        public Form1()
        {
            InitializeComponent();
            booking = new BookingViewModel();
        }

        
        public void SetFirstName(object sender, EventArgs e)
        {
            booking.FirstName = firstName.Text;
        }
        public void SetLastName(object sender, EventArgs e)
        {
            booking.LastName = lastName.Text;
        }

        public void SetStudentId(object sender, EventArgs e)
        {
            booking.StudentId = studentId.Text;
        }

        private void radio_room_i102_CheckedChanged(object sender, EventArgs e)
        {
            booking.SelectedRoom = "i102";
        }

        private void radio_room_a123_CheckedChanged(object sender, EventArgs e)
        {
            booking.SelectedRoom = "a123";
        }

        private void radio_room_i110_CheckedChanged(object sender, EventArgs e)
        {
            booking.SelectedRoom = "i110";
        }

        private void bookMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            booking.BookedDateTime = bookMonthCalendar.SelectionStart;
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            if (booking.IsValidBooking())
            {
                confirmationLabel.Text = booking.ToString();
            }
            else
            {
                confirmationLabel.Text = "Please select all values";
            }
            
        }
    }
}
