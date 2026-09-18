using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Models
{
    internal class Hall
    {
       public int Number { get; set; }

       public List<Seat> seats { get; set; }

        public Hall(int number)

        {
            Number = number;
            seats = new List<Seat>();

            for(int i=1; i<=50 ;i++)
            {
                Seat seat = new Seat(i);
                seats.Add(seat);
            }
        }

    }
}
