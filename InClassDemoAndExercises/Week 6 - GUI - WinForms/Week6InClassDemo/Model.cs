using System;

namespace Week6Demo
{
    public class BookingViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }

        public string SelectedRoom { get; set; }

        public DateTime BookedDateTime { get; set; }

        public override string ToString()
        {
            return $"Thank you! Lab {SelectedRoom} booked on {BookedDateTime} for {FirstName} {LastName}";
        }

        public bool IsValidBooking()
        {
            return 
                (BookedDateTime != null && BookedDateTime != DateTime.MinValue) &&
                (SelectedRoom != string.Empty) &&
                (FirstName != string.Empty) &&
                (LastName != string.Empty) &&
                (StudentId != string.Empty);
        }
    }
}
