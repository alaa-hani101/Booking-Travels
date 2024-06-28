using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new destination in Egypt
            Destinations destination = new Destinations();
            Console.WriteLine("Enter the name of destination :");
            destination.Name = Console.ReadLine();
            destination.Description = "Explore the ancient wonders of "+destination.Name;
            Console.WriteLine(destination.Description);
            Console.WriteLine("Enter the number of seats :");
            destination.Seats=int.Parse(Console.ReadLine());

            // Create a new tour
            Tour tour = new Tour();
            Console.WriteLine(" Enter the name of tour :");
            tour.Name = Console.ReadLine();
            tour.Description = "Experience the magic of "+tour.Name+ " and its historical sites";
            Console.WriteLine(tour.Description);
            tour.Duration = int.Parse(Console.ReadLine());
           Console.WriteLine( tour.Price = 1500.00f);

            // Add the destination to the tour
            //Tour.AddDestination();

            /* // Making Boking 
             int numofseats = int.Parse(Console.ReadLine());
             Customer cust = new Customer();

             Tour.MakingBooking(cust ,numofseats);
            */
            Console.WriteLine(" Enter the num of seats :");
            Bookings book1 = new Bookings();
            book1.NumberOfSeats = int.Parse(Console.ReadLine());
            Console.WriteLine(" number of available seats is :");
            Console.WriteLine(Tour.GetAvilableSeats());



        }
    }
}
