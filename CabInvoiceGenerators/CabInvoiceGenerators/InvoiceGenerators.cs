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
        /// <summary>
        /// Totals the fare.
        /// </summary>
        /// <param name="Rides">The rides.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Totals the rides.
        /// </summary>
        /// <param name="rides">The rides.</param>
        /// <returns></returns>
        public double TotalRides(Ride[] rides)
        {
            return rides.Length;
        }
        /// <summary>
        /// Averages the foreach rides.
        /// </summary>
        /// <param name="rides">The rides.</param>
        /// <returns></returns>
        public double AverageForeachRides(Ride[] rides)
        {
            InvoiceGenerators invoiceGenerators = new InvoiceGenerators();
           double totalfare = invoiceGenerators.totalFare(rides);
            double totalrides = invoiceGenerators.TotalRides(rides);
            double avgfare = totalfare / totalrides ;
            return avgfare;
        }
    }
}
