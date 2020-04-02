using NUnit.Framework;
using TDDQualityMeasurement;

namespace NUnitTestProject
{
    public class FeetToInchesTestCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenFeetValue_Checking_Equality_Feet()
        {
            Feet obj = new Feet(0);
            Assert.AreEqual(obj.ConvertedFeetValue(0), true);
        }
        [Test]
        public void GivenNullFeetValue_Checking_ReferenceType()
        {
            Feet obj = new Feet(0);
            Assert.AreEqual(obj.Equals(null), false);
        }
        [Test]
        public void GivenFeetValue_Checking_ReferenceType()
        {
            Feet obj = new Feet(0);
            Assert.AreEqual(obj.Equals(obj), true);
        }
        [Test]
        public void GivenFeetValue_Checking_Feet_Type()
        {
            Feet obj = new Feet(0);
            Assert.AreEqual(obj.Equals(obj), true);
        }
        [Test]
        public void GivenFeetValue_Checking_Feet_Value()
        {
            Feet feet = new Feet(10);
            Assert.AreEqual(feet.ConvertedFeetValue(10), true);
        }
        [Test]
        public void GivenInchValue_Checking_Equality_Inch()
        {
            Inches inches = new Inches(12);
            Assert.AreEqual(inches.CheckInchvalue(12), true);
        }
        [Test]
        public void GivenNullInchValue_Checking_ReferenceType()
        {
            Inches inches = new Inches(0);
            Assert.AreEqual(inches.Equals(null), false);
        }
        [Test]
        public void GivenInchValue_Checking_ReferenceType()
        {
            Inches inches = new Inches(0);
            Assert.AreEqual(inches.Equals(inches), true);
        }
        [Test]
        public void GivenInchValue_Checking_Inch_Type()
        {
            Inches inches = new Inches(0);
            Assert.AreEqual(inches.Equals(inches), true);
        }
        [Test]
        public void GivenInchValue_Checking_Inch_Value()
        {
            Inches inches = new Inches(10);
            Assert.AreEqual(inches.CheckInchvalue(10), true);
        }
        [Test]
        public void GivenFeetValue_Should_Comparewith_InchValue()
        {
            int feet = 0;
            int inch = 0;
            FeetToInches feettoinches = new FeetToInches();
            Assert.AreEqual(feettoinches.ConvertedFeetToInches(feet, inch), true);
        }
        [Test]
        public void GivenFeetValue_Should_ComparewithWrong_InchValue()
        {
            int feet = 1;
            int inch = 1;
            FeetToInches feettoinches = new FeetToInches();
            Assert.AreEqual(feettoinches.ConvertedFeetToInches(feet, inch), false);
        }
        [Test]
        public void GivenFeetValue_Should_Comparewith_InchValue_ReturnBoolvalue()
        {
            int feet = 1;
            int inch = 12;
            FeetToInches feettoinches = new FeetToInches();
            Assert.AreEqual(feettoinches.ConvertedFeetToInches(feet, inch), true);
        }
    }
}
