// See https://aka.ms/new-console-template for more information
using CabInvoiceGenerator;

Console.WriteLine("Welcome to Cab Invoice Generator");

while (true)
{
    Console.WriteLine("Please choose the option :\n1)Calculating Fare For a Ride\n2)Calculate Aggregate fare for Multiple Rides\n3)Print Invoice(Num_of_Rides,Aggregate_Fare,Average_Fare_per_Ride)\n4)Get Invcoice With UserID");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            InvoiceGenerator uc1 = new InvoiceGenerator();
            double Fare = uc1.TotalFare(10, 5);
            Console.WriteLine("Total Fare for Journey = " + Fare + "\n");
            break;
        case 2:
            InvoiceGenerator uc2 = new();
            MultipleRides[] rides = { new MultipleRides(10, 20), new MultipleRides(15, 25) };
            double Fare1 = uc2.TotalFare(rides);
            Console.WriteLine("The Aggregate Fare Value for All Rides = " + Fare1 + "\n");
            break;
        case 3:
            InvoiceGenerator uc3 = new();
            MultipleRides[] rides1 = { new MultipleRides(10, 20), new MultipleRides(15, 25), new MultipleRides(20, 30) };
            double Fare2 = uc3.TotalFare(rides1);
            
            int NumOfRides = 3;
            double AverageFare = Fare2 / NumOfRides;
            
            Console.WriteLine("Total Number of Rides : " + NumOfRides);
            Console.WriteLine("The Aggregate Fare Value for All Rides :" + Fare2);
            Console.WriteLine("Average Fare per Ride :" + AverageFare + "\n");
            break;
        case 4:
            InvoiceGenerator uc4 = new();
            Console.WriteLine("Please enter the user id :");
            string UserId = Console.ReadLine();
            MultipleRides[] rides2 = { new MultipleRides(10, 20), new MultipleRides(15, 25), new MultipleRides(20, 30) };
            double Fare3 = uc4.TotalFare(rides2);

            int numOfRides1 = 3;
            double Average = Fare3 / numOfRides1;

            RideRepository r1 = new();
            r1.AddRides(UserId, rides2);

            Console.WriteLine("************** Invoice **************");
            MultipleRides[] ride3 = r1.GetRide(UserId);
            Console.WriteLine("Total Number of rides : " + numOfRides1);
            uc4.InvoiceSummary(rides2);
            Console.WriteLine("Aggregate fare is :" + Fare3);
            Console.WriteLine("Average of all the rides :" + Average);
            Console.WriteLine("\n");
            break;
        default:
            Console.WriteLine("Please choose the above Options only");
            break;
    }
}





    
