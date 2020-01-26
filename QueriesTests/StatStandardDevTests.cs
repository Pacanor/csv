using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Queries.Tests
{
    [TestClass()]
    public class StatStandardDevTests
    {
        [TestMethod()]
        public void StandDevIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var standDev = StatStandardDev.StandDev(values);
            Assert.AreEqual(1.41421, Math.Round(standDev, 5, MidpointRounding.AwayFromZero));
        }

        [TestMethod()]
        public void StandDevDoubleTest()
        {
            double[] values = { 1.3, 2.1, 3.7, 4.5, 5.8 };
            var standDev = StatStandardDev.StandDev(values);
            Assert.AreEqual(1.62037, Math.Round(standDev, 5, MidpointRounding.AwayFromZero));
        }
    }
}