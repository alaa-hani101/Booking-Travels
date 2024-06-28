using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace FinalProject
{
    internal class Destinations:TravelEntity
    {
         protected int seats;
        public Destinations():base(name,description) { }
        public Destinations(int seats,string name,string description):base(name,description)
        {
            this.seats = seats;
        }
        public int Seats
        {
            set { seats = value; }
            get { return seats; }
        }

        



    }
}
