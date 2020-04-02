using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDQualityMeasurement;

namespace NUnitTestProject
{
    class FeetToYardTestCases
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GivenYardValue_Checking_EqualityYard()
        {
            Yard obj = new Yard(0);
            Assert.AreEqual(obj.CheckYardValue(0), true);
        }
        [Test]
        public void GivenNullYardValue_Checking_ReferenceType()
        {
            Yard obj = new Yard(0);
            Assert.AreEqual(obj.Equals(null), false);
        }
        [Test]
        public void GivenYardValue_Checking_ReferenceType()
        {
            Yard obj = new Yard(0);
            Assert.AreEqual(obj.Equals(obj), true);
        }
        [Test]
        public void GivenYardValue_Checking_Yard_Type()
        {
            Yard obj = new Yard(0);
            Assert.AreEqual(obj.Equals(obj), true);
        }
        [Test]
        public void GivenYardValue_Checking_Yardalue()
        {
            Yard obj = new Yard(10);
            Assert.AreEqual(obj.CheckYardValue(10), true);
        }
        [Test]
        public void GivenYardValue_FeetValue_CheckingValue()
        {
            double feet = 3;
            double yard = 1;
            FeetToYard feettoyard = new FeetToYard();
            feettoyard.ConvertFeetToYard(feet, yard);
        }
        [Test]
        public void GivenYardValue_InchValue_CheckingValue()
        {
            double inch = 36;
            double yard = 1;
            FeetToYard feettoyard = new FeetToYard();
            feettoyard.ConvertFeetToYard(inch, yard);
        }

    }
}
