// See https://aka.ms/new-console-template for more information
using CabInvoiceGenerator;

Console.WriteLine("Welcome to Cab Invoice Generator");

while (true)
{
    Console.WriteLine("Please choose the option :\n1)Calculating Fare For a Ride\n2)Calculate Aggregate fare for Multiple Rides");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double Fare = invoiceGenerator.TotalFare(10, 5);
            Console.WriteLine("Total Fare for Journey = " + Fare + "\n");
            break;
        case 2:
            InvoiceGenerator uc2 = new();
            MultipleRides[] rides = { new MultipleRides(10, 20), new MultipleRides(15, 25) };
            double Fare1 = uc2.TotalFare(rides);
            Console.WriteLine("The Aggregate Fare Value for All Rides = " + Fare1 + "\n");
            break;
        default:
            Console.WriteLine("Please choose the above Options only");
            break;
    }
}





    
