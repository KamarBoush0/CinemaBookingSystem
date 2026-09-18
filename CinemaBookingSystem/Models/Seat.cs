using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Models
{
    internal class Seat
    {
        public int Number { get; set; }

       public Seat(int number)
        {
            Number = number;
        }
    }
}
