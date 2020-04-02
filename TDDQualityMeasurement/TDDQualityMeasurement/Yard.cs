using System;
using System.Collections.Generic;
using System.Text;

namespace TDDQualityMeasurement
{
    public class Yard
    {
        double yard;
        /// <summary>
        /// Initializes a new instance of the <see cref="Yard"/> class.
        /// </summary>
        /// <param name="yard">The yard.</param>
        public Yard(double yard)
        {
            this.yard = yard;
        }
        /// <summary>
        /// Checks the yard value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public bool CheckYardValue(double value)
        {
            if (yard == value)
                return true;
            return false;
        }
    }
}
