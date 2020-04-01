using CabInvoiceGenerators;
using NUnit.Framework;
using System;
using System.Collections.Generic;


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
            InvoiceModel.COST_PER_TIME1 = 1;
            InvoiceModel.MINIMUM_COST_PER_KILOMETER1 = 10;
            InvoiceModel.MINIMUM_FARE1 = 5;
            Assert.GreaterOrEqual(invoicegenerators.InvoiceCalculateFare(10, 20), 5);
        }
        /// <summary>
        /// Givens the mulitple rides should return total fare.
        /// step2
        /// </summary>
        [Test]
        public void GivenMulitpleRides_ShouldReturn_TotalFare()
        {
            InvoiceModel.COST_PER_TIME1 = 1;
            InvoiceModel.MINIMUM_COST_PER_KILOMETER1 = 10;
            InvoiceModel.MINIMUM_FARE1 = 5;
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
            InvoiceModel.COST_PER_TIME1 = 1;
            InvoiceModel.MINIMUM_COST_PER_KILOMETER1 = 10;
            InvoiceModel.MINIMUM_FARE1 = 5;
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
            InvoiceModel.COST_PER_TIME1 = 1;
            InvoiceModel.MINIMUM_COST_PER_KILOMETER1 = 10;
            InvoiceModel.MINIMUM_FARE1 = 5;
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
        /// <summary>
        ///   <para>
        ///  Givens the user identifier should return rides</para>
        ///   <para></para>
        /// </summary>
        [Test]
        public void GivenUserID_Should_Return_Rides()
        {
            InvoiceModel.COST_PER_TIME1 = 1;
            InvoiceModel.MINIMUM_COST_PER_KILOMETER1 = 10;
            InvoiceModel.MINIMUM_FARE1 = 5;
            Ride[] Rides =
          {
               new Ride(5,12),
               new Ride(12,40),
               new  Ride(0.2,5),
           };
            Ride[] Ride2 =
         {
               new Ride(5,12),
               new Ride(10,4),
               new  Ride(0.2,5),
           };
            Ride[] Ride1 =
         {
               new Ride(5,12),
               new Ride(19,40),
               new  Ride(0.2,5),
           };
            Dictionary<string, Ride[]> keyValuePairs = new Dictionary<string, Ride[]>();
            keyValuePairs.Add("abc.gmail", Rides);
            keyValuePairs.Add("adf.gmail", Ride1);
            keyValuePairs.Add("ajc.gmail", Ride2);
            var list = invoicegenerators.GivenUserId(keyValuePairs, "abc.gmail");
            Assert.NotZero(list.Capacity);
        }
        /// <summary>
        /// <para>
        ///  Givens the user identifier should return rides</para>
        ///   <para></para>
        /// </summary>
        [Test]
        public void GivenDistance_Time_ShouldReturn_PremiumFare()
        {
            InvoiceModel.COST_PER_TIME1 =2 ;
            InvoiceModel.MINIMUM_COST_PER_KILOMETER1 = 15;
            InvoiceModel.MINIMUM_FARE1 = 20;
            Assert.GreaterOrEqual(invoicegenerators.InvoiceCalculateFare(16, 30),20);
        }
    }
}
