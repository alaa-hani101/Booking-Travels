using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Tour:TravelEntity
    {
        int duration;
        float price;
        Destinations destination;
        Bookings booking;
        public Tour():base()
        { }
        public Tour(int duration ,float price ,string name, string description):base(name,description)
        {
            this.duration = duration;
            this.price = price;
        }
        // Properities  >>> start
        public int Duration
        {
            set { duration = value; }
            get { return duration; }
        }
        public float Price
        {
            set { price = value; }
            get { return price; }
        }
        public Destinations Destination
        {
            set { destination = value; }
            get { return destination; }
        }
        public Bookings Booking
        {
            set { booking = value; }
            get { return booking; }
        }
        //  >> end
        public void AddDestination()
        {
            List<Destinations> destination = new List<Destinations>();
            Destinations dest1 = new Destinations(23,"rome","a butiful city to visit");
            destination.Add(dest1);
        }

        //public void RemoveDestinatons()
        //{

        //}
        public string MakingBooking(Customer cust,int numOfSeats )
        {
            return " booking created successfuly . ";
        }

        public int GetAvilableSeats()
        {

            return destination.Seats - booking.NumberOfSeats;
        }

    }
}
