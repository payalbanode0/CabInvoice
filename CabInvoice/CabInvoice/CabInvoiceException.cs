using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoice
{
    //Custom Exception Handling Class
    public class CabInvoiceException : Exception
    {
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE, INVALID_DISTANCE, INVALID_TIME, INVALID_RIDES, INVALID_USER_ID, NULL_RIDES
        }
        ExceptionType type;
        //parameterized Construction
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;

        }
    }
}