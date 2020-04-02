using System;
using System.Collections.Generic;
using System.Text;

namespace TDDQualityMeasurement
{
    public class Inches
    {
        double inches;
        /// <summary>
        /// Initializes a new instance of the <see cref="Inches"/> class.
        /// </summary>
        /// <param name="inches">The inches.</param>
        public Inches(double inches)
        {
            this.inches = inches;
        }
        /// <summary>
        /// Checks the inchvalue.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public bool CheckInchvalue(double value)
        {
            if (inches == value)
                return true;
            return false;
        }

    }
}
