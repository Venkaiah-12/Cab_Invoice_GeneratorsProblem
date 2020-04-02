using System;
using System.Collections.Generic;
using System.Text;

namespace TDDQualityMeasurement
{
    public class FeetToInches
    {
        double inches = 12;
        /// <summary>
        /// Converteds the feet to inches.
        /// </summary>
        /// <param name="feet">The feet.</param>
        /// <param name="inch">The inch.</param>
        /// <returns></returns>
        public bool ConvertedFeetToInches(double feet, double inch)
        {
            if (inch == feet * inches)
                return true;
            return false;
        }
    }
}
