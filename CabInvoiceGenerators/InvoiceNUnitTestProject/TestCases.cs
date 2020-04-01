using CabInvoiceGenerators;
using NUnit.Framework;
using System;

namespace InvoiceNUnitTestProject.CabInvoiceGenerators
{

    public class Tests
    {
        private InvoiceGenerators invoicegenerators = new InvoiceGenerators();
        [SetUp]
        public void Setup()
        {

        }
        /// <summary>
        /// Givens the distance time should return total fare.
        /// step 1
        /// </summary>
        [Test]
        public void GivenDistance_Time_ShouldReturn_TotalFare()
        {
            Assert.GreaterOrEqual(invoicegenerators.InvoiceCalculateFare(10, 20), 5);
        }
        /// <summary>
        /// Givens the mulitple rides should return total fare.
        /// step2
        /// </summary>
        [Test]
        public void GivenMulitpleRides_ShouldReturn_TotalFare()
        {
            Ride[] Rides =
           {
               new Ride(5,12),
               new Ride(12,40),
               new  Ride(0.2,5),
           };
            double actual = invoicegenerators.totalFare(Rides);
            double excepted = invoicegenerators.InvoiceCalculateFare(5, 12) + invoicegenerators.InvoiceCalculateFare(12, 40) +
                invoicegenerators.InvoiceCalculateFare(0.2, 5);
            Assert.AreEqual(actual, excepted);
        }
        /// <summary>
        /// Givens the mulitple rides should return total rides.
        /// step 3
        /// </summary>
        [Test]
        public void GivenMulitpleRides_ShouldReturn_TotalRides()
        {
            Ride[] Rides =
           {
               new Ride(5,12),
               new Ride(12,40),
               new  Ride(0.2,5),
           };
            double actual = invoicegenerators.TotalRides(Rides);
            double excepted = Rides.Length;
            Assert.AreEqual(actual, excepted);
        }
        /// <summary>
        /// Givens the mulitple rides should return total average rides.
        /// step 3
        /// </summary>
        [Test]
        public void GivenMulitpleRides_ShouldReturn_Total_AverageRides()
        {
            Ride[] Rides =
           {
               new Ride(5,12),
               new Ride(12,40),
               new  Ride(0.2,5),
           };
            double actual = invoicegenerators.AverageForeachRides(Rides);
            double Total = invoicegenerators.InvoiceCalculateFare(5, 12) + invoicegenerators.InvoiceCalculateFare(12, 40) +
                 invoicegenerators.InvoiceCalculateFare(0.2, 5);
            double excepted = Total / Rides.Length;
            Assert.AreEqual(actual, excepted);
        }
    }
}