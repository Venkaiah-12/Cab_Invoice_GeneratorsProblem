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
        /// Invoices the calculate fare.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <param name="time">The time.</param>
        /// <returns></returns>
       public double InvoiceCalculateFare(double distance, double time)
        {
            double totalfare = distance * InvoiceModel.MINIMUM_COST_PER_KILOMETER1 + time;
            return Math.Max(totalfare, InvoiceModel.MINIMUM_FARE1);
        }
        public double totalFare(Ride[] Rides)
        {
            double totalfare = 0;
            InvoiceGenerators invoiceGenerators = new InvoiceGenerators();
            foreach(var ride in Rides)
            {
                totalfare += invoiceGenerators.InvoiceCalculateFare(ride.distance, ride.time);
            }
            return totalfare;


        }
    }
}
