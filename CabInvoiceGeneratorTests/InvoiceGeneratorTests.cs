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
            double Fare = invoiceGenerator.TotalFare(10,5);
            Assert.AreEqual(105, Fare);
        }

        [TestMethod()]
        public void TotalFareTest1()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double Fare = invoiceGenerator.TotalFare(0.3, 2);
            Assert.AreEqual(5, Fare);
        }
    }
}