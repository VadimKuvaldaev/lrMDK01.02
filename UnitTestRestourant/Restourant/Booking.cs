using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restourant
{
    public class Booking
    {
        private int bookingNumber_;
        private int number_;
        private DateTime startTime_;

        public Booking(int bookingNumber, int number, string clientName, DateTime startTime, int durationMinutes)
        {
            bookingNumber_ = bookingNumber;
            number_ = number;
            ClientName = clientName;
            startTime_ = startTime;
            DurationMinutes = durationMinutes;
        }

        public int Table { get; set; } 
        public string ClientName { get; set; }
        public DateTime BookingDate { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime EndTime { get; set; }
    }
}
