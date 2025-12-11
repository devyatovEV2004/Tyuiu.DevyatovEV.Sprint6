using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint6.Task0.V23.Lib;
using System;

namespace Tyuiu.DevyatovEV.Sprint6.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc_Valid()
        {
            var calc = new DataService();
            int x = 3;
            var result = calc.Calculate(x);

            double expected = -0.223;
            Assert.AreEqual(expected, result);
        }
    }
}