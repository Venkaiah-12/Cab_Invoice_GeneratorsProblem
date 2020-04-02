using System;
using System.Collections.Generic;
using System.Text;

namespace TDDQualityMeasurement
{
   public  class Inches
    {
        double inches;
       public Inches(double inches)
        {
            this.inches = inches;
        }
        public bool CheckInchvalue(double value)
        {
            if (inches == value)
                return true;
            return false;
        }
        
    }
}
