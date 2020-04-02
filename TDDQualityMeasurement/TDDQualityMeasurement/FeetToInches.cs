using System;
using System.Collections.Generic;
using System.Text;

namespace TDDQualityMeasurement
{
  public  class FeetToInches
    {
        double inches = 12;
        public bool ConvertedFeetToInches(double feet, double inch)
        {
            if (inch == feet * inches)
                return true;
            return false;
        }
    }
}
