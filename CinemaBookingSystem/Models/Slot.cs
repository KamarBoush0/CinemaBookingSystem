using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Models
{
    internal class Slot
    {
        public int Time { get; set; }

        public Hall Hall { get; set; }
        public Movie Movie{ get; set; }

        public Slot(int time, Hall hall, Movie movie)
        {
            Time = time;
            Hall = hall;
            Movie = movie;
        }

    }
}
