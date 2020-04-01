using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerators
{
    /// <summary>
    ///   <para>creating the class for cab invoice generator and calculating the rides</para>
    ///   <para></para>
    /// </summary>
    public class InvoiceGenerators
    {
        /// <summary>
        /// Invoices the specified distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <param name="time">The time.</param>
        /// <returns></returns>
        public double Invoice(int distance, int time)
        {
            double totalfare = distance * InvoiceModel.MINIMUM_COST_PER_KILOMETER1 + time;
            return Math.Max(totalfare, InvoiceModel.MINIMUM_FARE1);
        }
    }
}
