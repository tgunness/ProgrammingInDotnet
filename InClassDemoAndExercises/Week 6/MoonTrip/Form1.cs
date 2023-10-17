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


            if(departureMonthCalendar.MinDate > firstSaturdayOfMonth) //if user selected current month, and first saturday has already passed, then pick next month's first saturday
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
        /// Book the trip but creating an AstronautTrip object and adding it to the listbox.
        /// This can only be done with an astronaut's name and a selected date.
        /// An astronaut can only be listed once per trip.
        /// There is a maximum of three astronauts per trip.
        /// The lisatbox is sorted by departure date.
        /// </summary>
        /// <param name="sender">Default sender</param>
        /// <param name="e">Default event arguments</param>
        private void BookTripButton_Click(object sender, EventArgs e)
        {
            // Assume we'll be issuing error messages
            statusLabel.ForeColor = Color.Red;

            // Create an AstronautTrip object with the current values
            AstronautTrip newTrip = new AstronautTrip(astronautTextBox.Text, departureMonthCalendar.SelectionStart.AddHours(6).AddMinutes(15));

            int count = 0;             // How many astronauts are already booked for this trip
            bool booked = false;       // If this astronaut is already booked for this trip

            // Go through each entry in the listbox and determine how many match the selected departure date, and if the astronaut is already booked
            foreach (AstronautTrip trip in tripListBox.Items)
            {
                if (trip.Depart.Equals(newTrip.Depart))
                {
                    count++;

                    if (trip.Name.Equals(newTrip.Name))
                        booked = true;
                }
            }

           

            // Everything is good, so add to the listbox
            else
            {
                tripListBox.Items.Add(newTrip);
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Trip successfully booked.";

                // Sort the listbox by departure date
                SortList();
                astronautTextBox.Focus();
            }
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

        /// <summary>
        /// This method will sort the listbox contents. The listbox can only be default sorted
        /// as a string but we'd like to sort by departure times.
        /// 
        /// To do this, copy the contents out to a list, sort the list, then copy the list
        /// contents back to the listbox.
        /// </summary>
        private void SortList()
        {
            List<AstronautTrip> sortedList = tripListBox.Items.Cast<AstronautTrip>().ToList();

            sortedList.Sort();

            tripListBox.Items.Clear();

            tripListBox.Items.AddRange(sortedList.ToArray());
        }
    }
}
