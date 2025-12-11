using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint6.Task1.V21.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMass_Alternative()
        {
            var calc = new DataService();
            var vals = calc.GetMassFunction(-5, 5);

            // Проверим основные точки
            Assert.AreEqual(20.36, vals[0], 0.01);   // x = -5
            Assert.AreEqual(0.00, vals[6], 0.01);    // x = 1 (деление на ноль)
            Assert.AreEqual(-19.60, vals[10], 0.01); // x = 5

            // Проверим длину массива
            Assert.AreEqual(11, vals.Length);
        }

    }
}