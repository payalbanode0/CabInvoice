using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoice
{
    //Class to Set Data for Particular Ride
    public class Ride
    {
        public double distace;
        public int time;

        //Parameterized Constructor for setting data
        public Ride(double distance, int time)
        {
            this.distace = distance;
            this.time = time;
        }
    }
}