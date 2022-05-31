﻿// See https://aka.ms/new-console-template for more information
using CabInvoiceGenerator;

Console.WriteLine("Welcome to Cab Invoice Generator");

while (true)
{
    Console.WriteLine("Please choose the option :\n1)Calculating Fare For a Ride\n2)Calculate Aggregate fare for Multiple Rides");
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
        default:
            Console.WriteLine("Please choose the above Options only");
            break;
    }
}





    
