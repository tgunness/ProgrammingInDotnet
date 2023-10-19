using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace MoonTrip
{
    /// <summary>
    /// This program is solution to Lab Exercise 6 - Moon Trip
    ///
    /// Purpose: Add astronauts to a listbox and schedule their departure times.
    ///          There is a maximum of three astronauts per trip.
    ///          An astronaut can't be on the same trip more than once.
    ///          Launches are only scheduled on the first Saturday of a month.
    /// 
    /// Ref: This code is adapted from solution provided by Nicholas J. Corkigian created Oct. 10 2019
    /// </summary>
    public partial class Form1 : Form
    {
        public List<AstronautTrip> _allBookedTrips;
        public Form1()
        {
            InitializeComponent();
            departureMonthCalendar.MinDate = DateTime.Now; //The MinDate property is set to prevent a user from selecting a Date earlier than today
            _allBookedTrips = new List<AstronautTrip>();
        }

        private bool validDate = false;  // Set when a valid departure date is selected

        /// <summary>
        /// Validate the departure date to be the first Saturday of the month. If that date has passed, 
        /// reschedule for the following month.
        /// </summary>
        /// <param name="sender">Default sender</param>
        /// <param name="e">Default event arguments</param>
        private void DepartureMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime rescheduledDate;
            DateTime firstSaturdayOfMonth = GetFirstSaturday(departureMonthCalendar.SelectionStart);


            if (departureMonthCalendar.MinDate > firstSaturdayOfMonth) //if user selected current month, and first saturday has already passed, then pick next month's first saturday
            {
                statusLabel.ForeColor = Color.Red;
                validDate = false;
                statusLabel.Text = "First Saturday of this month has passed.\nRescheduling to next available time.";
                rescheduledDate = GetFirstSaturday(new DateTime(departureMonthCalendar.SelectionStart.Year, departureMonthCalendar.SelectionStart.Month + 1, departureMonthCalendar.SelectionStart.Day)); //get first saturday of next month
            }
            else if (departureMonthCalendar.SelectionStart != firstSaturdayOfMonth)
            {
                statusLabel.ForeColor = Color.Red;
                validDate = false;
                statusLabel.Text = "Must be first Saturday.\nRescheduling to next available time.";
                rescheduledDate = firstSaturdayOfMonth;
            }
            else
            {
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Valid date selected.";
                rescheduledDate = departureMonthCalendar.SelectionStart;
            }

            // Set the departure date and turn on the valid date flag
            departureMonthCalendar.SetDate(rescheduledDate);
            validDate = true;
        }


        /// <summary>
        /// For any given input, determines the first Saturday
        /// </summary>
        /// <param name="inputDate"></param>
        /// <returns></returns>
        private DateTime GetFirstSaturday(DateTime inputDate)
        {
            // Calculate the first day of the month for the input date
            DateTime firstDayOfMonth = new DateTime(inputDate.Year, inputDate.Month, 1);

            // Calculate the number of days until the next Saturday
            int daysUntilSaturday = (int)DayOfWeek.Saturday - (int)firstDayOfMonth.DayOfWeek;
            if (daysUntilSaturday < 0)
                daysUntilSaturday += 7;

            // Add the number of days to the first day of the month to get the first Saturday
            DateTime firstSaturday = firstDayOfMonth.AddDays(daysUntilSaturday);

            return firstSaturday;
        }

        /// <summary>
        /// Book the trip by first validating form inputs so that
        ///   - name is given
        ///   - no more than 3 people booked on selected date
        ///   - name isn't already booked
        /// Once form is valid we add trip to _allBookedTrips
        /// Then refresh the ListBox, sorting trips by depart date
        /// </summary>
        /// <param name="sender">Default sender</param>
        /// <param name="e">Default event arguments</param>
        private void BookTripButton_Click(object sender, EventArgs e)
        {
            // Valid Form Inputs

            bool isValid = true;
            statusLabel.ForeColor = Color.Red;
            statusLabel.Text = "";

            // Astronauts need a name
            if (astronautTextBox.Text == String.Empty)
            {
                isValid = false;
                statusLabel.Text += "Astronaut name is required.\n";
                astronautTextBox.Focus();
            }

            // Each trip has a maximum of three astronauts that can be booked, count number books on the selected Date (.Date is how we ignore time)
            if (_allBookedTrips.Count(t => t.Depart.Date.Equals(departureMonthCalendar.SelectionStart.Date)) >= 3)
            {
                isValid = false;
                statusLabel.Text += "Capsule is fully booked on this date, it can only carry 3 persons on single trip.\n";
            }

            // Each trip has a maximum of three astronauts that can be booked
            if (_allBookedTrips.Any(t => t.Name.ToLower() == astronautTextBox.Text.ToLower()))
            {
                isValid = false;
                statusLabel.Text += $"{astronautTextBox.Text} is already booked for this trip.\n";
            }

            // A valid date needs to be selected
            if (!validDate)
            {
                isValid = false;
                statusLabel.Text += "Valid date needs to be selected.\n";
                departureMonthCalendar.Focus();
            }

            if (isValid)
            {
                _allBookedTrips.Add(new AstronautTrip(astronautTextBox.Text, departureMonthCalendar.SelectionStart.AddHours(6).AddMinutes(15)));
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Trip successfully booked.";
            }

            RefreshBookingsView();
        }


        private void RefreshBookingsView()
        {
            tripListBox.Items.Clear();
            tripListBox.Items.AddRange(_allBookedTrips.OrderBy(a => a.Depart).ToArray());
        }



        /// <summary>
        /// The exit button will close the form and end the program.
        /// </summary>
        /// <param name="sender">Default sender</param>
        /// <param name="e">Default event arguments</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
