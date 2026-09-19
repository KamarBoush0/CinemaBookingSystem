using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaBookingSystem.Models;

namespace CinemaBookingSystem
{
    internal class Program
    {
        static List<Movie> movies = new List<Movie>();
        static List<Hall> halls = new List<Hall>();
        static List<Slot> slots = new List<Slot>();
        static List<Booking> bookings = new List<Booking>();
        
        static void Main(string[] args)
        {

            for (int i = 1; i <= 3; i++) //to create 3 halls objects and to stor it in the halls list
            {
                Hall hall = new Hall(i);
                halls.Add(hall);
            }


            bool running = true;
            int choise;

            //to keep the program running until the user chooses "exit"
            while (running)
            {
                ShowMenu();
                choise = ReadChoise(1, 5);

                switch (choise)
                {
                    case 1:
                        AddMovie();
                        break;
                    case 2:
                        ShowMovie();
                        break;
                    case 3:
                        AddSlot();
                        break;
                    case 4:
                        ShowSlots();
                        break;
                    case 5:
                        AddBooking();
                        break;
                    case 6:
                        running = false;
                        break;
                }
            }

        }


        static void ShowMenu()
        {
            Console.Write("1. Add Movie \n2. View Movies \n3. Add Slot\n4. View Slots\n5. Add booking\n6. Exit\n");
        }

        static int ReadNumber()
        {
            string input;

            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Try again ");
                }
            }
        }

        static int ReadChoise(int min, int max)
        {
            int choise;
            while (true)
            {
                choise = ReadNumber();
                if (choise >= min && choise <= max)
                {
                    return choise;
                }
                else
                {
                    Console.WriteLine("Try Agin: ");
                }
            }
        }
        static void AddMovie()
        {
            Console.Write("enter a title of movie: ");
            string title = Console.ReadLine();
            Console.Write("enter a duration of movie: ");
            int duration = ReadNumber();

            Movie movie = new Movie(title, duration);
            movies.Add(movie);
        }

        static void ShowMovie() //foreach
        {    if(movies.Count==0)
            {
                Console.WriteLine("No movies are available");
                return;
            }
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine((i+1)+". " + movies[i].Title);
                Console.WriteLine((i+1) + ". "+ movies[i].Duration);
            }
        }

        static void ShowHalls() //foreach
        {
            for (int i = 0; i < halls.Count; i++)
            {
                Console.WriteLine(halls[i].Number + ". hall " + (i + 1));
            }
        }

        static void ShowTime()
        {
            Console.WriteLine("1. 10:00\n2. 13:00\n3. 16:00\n4. 19:00\n5. 22:00");
        }

        static void ShowSlots()
        {
            if(slots.Count==0)
            {
                Console.WriteLine("No slots are available");
                return;
            }
            for(int i=0; i<slots.Count; i++) //foreach
            {
                Console.WriteLine((i+1) + ". " +" Hall "+ slots[i].Hall.Number + " | " + slots[i].Time + " | " + slots[i].Movie.Title);
            }
        }

       

        static void AddSlot()
        {
            int choise;
            int selectedTime;
            Hall selectedHall;
            Movie selectedMovie;
            bool found = false;

            Console.WriteLine("Choise a hall:");
            ShowHalls();
            choise = ReadChoise(1,halls.Count);
            selectedHall = halls[choise - 1];

            Console.WriteLine("Choise a time:");
            ShowTime();
            choise = ReadChoise(1,5);
            selectedTime = choise;

            Console.WriteLine("Choise a movie:");
            ShowMovie();
            choise = ReadChoise(1, movies.Count);
            selectedMovie = movies[choise - 1];


            for (int i = 0; i < slots.Count;i++) //foreach Slot slot in slots
            {
                if (selectedHall == slots[i].Hall && selectedTime == slots[i].Time)
                {
                    found = true;
                    break;
                }
            }

            if(found)
            {
                Console.WriteLine("This slot is aleady taken.");
            }
            else
            {
                Slot slot = new Slot(selectedTime, selectedHall, selectedMovie);
                slots.Add(slot);
            }
        }
        static void AddBooking()
        {
            int choise;
            int selectedSeatNumber;
            Slot selectedSlot;
            bool found = false;

            Console.WriteLine("Choise a slot:");
            ShowSlots();
            choise = ReadChoise(1,slots.Count);
            selectedSlot = slots[choise - 1];

            Console.WriteLine("Choise a seat number from 1 to 50: ");
            choise = ReadChoise(1, 50);
            selectedSeatNumber = choise;

  
            foreach(Booking booking in bookings)
            {
                if(selectedSlot==booking.Slot && selectedSeatNumber==booking.SeatNumber)
                {
                    found = true;
                    break;
                }
            }

            if(found)
            {
                Console.WriteLine("This seat is already booked.");
            }
            else
            {
                Booking booking = new Booking(selectedSlot, selectedSeatNumber);
                bookings.Add(booking);
            }
        }

    }
}
