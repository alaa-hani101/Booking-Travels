using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Bookings
    {
        int numberOfSeats;
        Customer customer;
        Tour tour;
        public int NumberOfSeats
        {
            set { numberOfSeats = value; }
            get { return numberOfSeats; }
        }

    }
}
