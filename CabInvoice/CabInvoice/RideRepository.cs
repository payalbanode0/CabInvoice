using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoice
{
    public class RideRepository
    {
        //Dictionary to Store UserId and Rides int List.
        Dictionary<string, List<Ride>> userRides = null;

        //Constructor to Create Dicitonary.
        public RideRepository()
        {
            this.userRides = new Dictionary<string, List<Ride>>();
        }

        //Function to Add Ride List to Specific UserID.
        public void AddRide(string userID, Ride[] rides)
        {
            bool rideList = this.userRides.ContainsKey(userID);
            try
            {
                if (!rideList)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.userRides.Add(userID, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Rides Are Null");
            }
        }
        public Ride[] GetRides(string userID)
        {
            try
            {
                return this.userRides[userID].ToArray();
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid User ID");
            }
        }
    }
}