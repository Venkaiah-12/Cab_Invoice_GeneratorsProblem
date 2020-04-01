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
        /// </summary>
        [Test]
        public void GivenDistance_Time_ShouldReturn_TotalFare()
        {
            Assert.GreaterOrEqual(invoicegenerators.InvoiceCalculateFare(10, 20), 5);
        }
        /// <summary>
        /// Givens the mulitple rides should return total fare.
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
    }
}