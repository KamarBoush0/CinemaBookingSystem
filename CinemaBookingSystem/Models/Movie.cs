using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Models
{
    internal class Movie
    {
        public string Title { get; set; }
        public int Duration { get; set; }

        public Movie(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }
    }
}
