﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerators
{
public class InvoiceModel
    {
        private static int COST_PER_TIME;
        private static double MINIMUM_COST_PER_KILOMETER;
        private static double MINIMUM_FARE;

        public static int COST_PER_TIME1 { get => COST_PER_TIME; set => COST_PER_TIME =value; }
        public static double MINIMUM_COST_PER_KILOMETER1 { get => MINIMUM_COST_PER_KILOMETER; set => MINIMUM_COST_PER_KILOMETER = value; }
        public static double MINIMUM_FARE1 { get => MINIMUM_FARE; set => MINIMUM_FARE = value; }
    }
}
