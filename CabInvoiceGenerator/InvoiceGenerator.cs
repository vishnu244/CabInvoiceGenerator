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

        public double TotalFare(MultipleRides[] ride, string RideType)
        {
            if (RideType == "Normal")
            {
                Cost_per_km = 10;
                Cost_per_Minute = 1;
                Min_Fare = 5;
            }
            else if (RideType == "Premium")
            {
                Cost_per_km = 15;
                Cost_per_Minute = 2;
                Min_Fare = 20;
            }
            double totalfare = 0;
            foreach (MultipleRides rides in ride)
            {
                totalfare = totalfare + TotalFare(rides.Distance, rides.Time_in_minutes);

            }
            return totalfare;
        }

        public void InvoiceSummary(MultipleRides[] ride, string RideType)
        {
            foreach (MultipleRides rides in ride)
            {

                Console.WriteLine("Distance Travelled :" + rides.Distance);
                Console.WriteLine("Time Taken :" + rides.Time_in_minutes);
                Console.WriteLine("Fare for ride is :" + TotalFare(rides.Distance, rides.Time_in_minutes) + "\n");
            }
        }
    }
}
