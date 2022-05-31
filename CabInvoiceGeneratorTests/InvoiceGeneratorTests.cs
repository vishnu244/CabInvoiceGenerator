using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator.Tests
{
    [TestClass()]
    public class InvoiceGeneratorTests
    {
        [TestMethod()]
        public void TotalFareTest()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double Fare = invoiceGenerator.TotalFare(10, 5);
            Assert.AreEqual(105, Fare);
        }

        [TestMethod()]
        public void TotalFareTest1()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double Fare = invoiceGenerator.TotalFare(0.3, 2);
            Assert.AreEqual(5, Fare);
        }

        [TestMethod()]
        public void TotalFareTest2()
        {
            InvoiceGenerator uc2 = new();
            MultipleRides[] rides = { new MultipleRides(10, 20), new MultipleRides(15, 25) };
            double Fare1 = uc2.TotalFare(rides);
            Assert.AreEqual(295, Fare1);
        }

        [TestMethod()]
        public void TotalFareTest3()
        {
            InvoiceGenerator uc3 = new();
            MultipleRides[] rides1 = { new MultipleRides(10, 20), new MultipleRides(15, 25), new MultipleRides(20, 30) };
            double Fare2 = uc3.TotalFare(rides1);

            int NumOfRides = 3;
            double AverageFare = Fare2 / NumOfRides;

            Assert.AreEqual(175, AverageFare);
        }
    }
}