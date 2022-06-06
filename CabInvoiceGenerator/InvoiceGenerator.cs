using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        public int Cost_per_km = 10;
        public int Cost_per_Minute = 1;
        public int Min_Fare = 5;


        public double TotalFare(double Distance, int Time_in_minutes)
        {
            double Fare = Cost_per_km * Distance + Cost_per_Minute * Time_in_minutes;
            return Math.Max(Fare, Min_Fare);
        }

        public double TotalFare(MultipleRides[] ride)
        {
            double Fare = 0;
            foreach (MultipleRides rides in ride)
            {
                Fare = Fare + TotalFare(rides.Distance, rides.Time_in_minutes);
            }
            return Fare;
        }

        public void InvoiceSummary(MultipleRides[] ride)
        {
            foreach (MultipleRides rides in ride)
            {

                Console.WriteLine("\n" + "Distance Travelled :" + rides.Distance);
                Console.WriteLine("Time Taken :" + rides.Time_in_minutes);
                Console.WriteLine("Fare for ride is :" + TotalFare(rides.Distance, rides.Time_in_minutes) + "\n");
            }
        }
    }
}
