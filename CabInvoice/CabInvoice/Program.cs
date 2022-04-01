using System;

namespace CabInvoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to InVoice Generator");
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoice.CalculatingFare(2.0, 5);
            //UC 5
            InvoiceGenerator invoice2 = new InvoiceGenerator(RideType.PREMIUM);
            double fare2 = invoice2.CalculatingFare(2.0, 5);
            Console.WriteLine($"Normal Ride Fare : {fare}");
            Console.WriteLine($"Premium Ride Fare : {fare2}");

        }
    }
}