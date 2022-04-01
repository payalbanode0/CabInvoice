using NUnit.Framework;
using CabInvoice;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        //InvoiceGenerator Reference
        InvoiceGenerator invoiceGenerator = null;
        //UC 1       
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            //Creating Instance of InvoiceGenerator For Normal ride.
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            //Calculate Fare
            double fare = invoiceGenerator.CalculatingFare(distance, time);
            double expected = 25;

            //Asserting Values
            Assert.AreEqual(expected, fare);
        }
        //UC 2
        [Test]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);

            //Asserting 
            Assert.AreEqual(expectedSummary, summary);
        }
        //UC 3
        [Test]
        public void GivenInvalidRideTypeShouldThrowCustomException()
        {
            //Creating Instance of InvoiceGenerator.
            invoiceGenerator = new InvoiceGenerator();
            double distance = 2.0;
            int time = 5;
            string expected = "Invalid Ride Type";
            try
            {
                //Calculate Fare
                double fare = invoiceGenerator.CalculatingFare(distance, time);
            }
            catch (CabInvoiceException exception)
            {
                //Asserting 
                Assert.AreEqual(expected, exception);
            }
        }
        //UC 4
        [Test]
        public void GivenInvalidDistanceShouldThrowCustomException()
        {
            //Creating instance of invoice Generator
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = -2.0;
            int time = 5;
            string expected = "Invalid Distance";
            try
            {
                //Calculate Fare
                double fare = invoiceGenerator.CalculatingFare(distance, time);
            }
            catch (CabInvoiceException exception)
            {
                //Asserting 
                Assert.AreEqual(expected, exception);
            }
        }
    }
}