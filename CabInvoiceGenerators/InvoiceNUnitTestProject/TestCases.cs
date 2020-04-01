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
             Assert.GreaterOrEqual(invoicegenerators.Invoice(10, 20),5);
        }
    }
}