using System;
using System.Collections.Generic;
using System.Text;

namespace TDDQualityMeasurement
{
    public class Feet
    {
        double feet;
        public Feet(double feet)
        {
            this.feet = feet;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) ||! this.GetType().Equals(obj.GetType()))
                return false;
            return true;
        }
        public bool ConvertedFeetValue(double feet)
        {
            if (this.feet.Equals(feet))
                return true;
            return false;
        }
    }
}
