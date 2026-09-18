using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Models
{
    internal class Booking
    {
        public Slot Slot { get; set; }
        public int SeatNumber { get; set; }

        public Booking(Slot slot, int seatNumber)
        {
            Slot = slot;
            SeatNumber = seatNumber;
        }
    }
}
