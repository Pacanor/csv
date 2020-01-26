using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Queries.Tests
{
    [TestClass()]
    public class StatMeanTests
    {
        [TestMethod()]
        public void MeanIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var mean = StatMean.Mean(values);
            Assert.AreEqual(3, mean);
        }

        [TestMethod()]
        public void MeanDoubleTest()
        {
            double[] values = { 1.3, 2.1, 3.7, 4.5, 5.8 };
            var mean = StatMean.Mean(values);
            Assert.AreEqual(3.48, mean);
        }
    }
}