﻿// See https://aka.ms/new-console-template for more information
using CabInvoiceGenerator;

Console.WriteLine("Welcome to Cab Invoice Generator");

InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
double Fare = invoiceGenerator.TotalFare();
Console.WriteLine("Total Fare for Journey = " + Fare);

    
