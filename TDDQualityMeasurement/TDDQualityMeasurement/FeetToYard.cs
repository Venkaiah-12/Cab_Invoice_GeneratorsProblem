using System;
using System.Collections.Generic;
using System.Text;

namespace TDDQualityMeasurement
{
    public class FeetToYard
    {
        double Feet = 3;
        double Inch = 36;
        /// <summary>
        /// Converts the feet to yard.
        /// </summary>
        /// <param name="feet">The feet.</param>
        /// <param name="yard">The yard.</param>
        /// <returns></returns>
        public bool ConvertFeetToYard(double feet, double yard)
        {
            if (feet == yard * Feet)
                return true;
            return false;
        }
        /// <summary>
        /// Converts the inch to yard.
        /// </summary>
        /// <param name="inch">The inch.</param>
        /// <param name="yard">The yard.</param>
        /// <returns></returns>
        public bool ConvertInchToYard(double inch, double yard)
        {
            if (inch == yard * Inch)
                return true;
            return false;
        }
    }
}
