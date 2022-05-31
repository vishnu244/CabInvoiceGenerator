using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class MultipleRides
    {
        public double Distance;
        public int Time_in_minutes;
        
        public MultipleRides(double Distance, int Time_in_minutes)
        {
            this.Time_in_minutes = Time_in_minutes;
            this.Distance = Distance;
        }
    }
}
