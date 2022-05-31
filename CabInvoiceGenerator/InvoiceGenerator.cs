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

        public double TotalFare()
        {
            Console.WriteLine("Please enter the Distance");
            double Distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the Time_in_Minutes");
            double Time_in_minutes = Convert.ToDouble(Console.ReadLine());

            double Fare = Cost_per_km * Distance + Cost_per_Minute * Time_in_minutes;
            return Math.Max(Fare, Min_Fare);
        }

    }
}
