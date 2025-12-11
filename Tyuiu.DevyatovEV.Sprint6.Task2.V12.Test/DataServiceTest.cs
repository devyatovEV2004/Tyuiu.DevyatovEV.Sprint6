using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint6.Task2.V12.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFunctionValues()
        {
            // Arrange
            var calc = new DataService();

            // Act
            double[] actual = calc.GetMassFunction(-5, 5);

            // Assert - проверяем несколько ключевых значений
            // x = -5
            // cos(-5) ≈ 0.2837, -5 + 0.2837 = -4.7163
            // (2*(-5)+6)/(-4.7163) = (-10+6)/(-4.7163) = (-4)/(-4.7163) ≈ 0.848
            // 0.848 - 3 = -2.152 ≈ -2.15
            Assert.AreEqual(-2.15, actual[0], 0.01, $"Mismatch at x = -5");

            // x = 0
            // cos(0) = 1, 0 + 1 = 1
            // (2*0+6)/1 = 6/1 = 6
            // 6 - 3 = 3.00
            Assert.AreEqual(3.00, actual[5], 0.01, $"Mismatch at x = 0");

            // Проверяем, что все значения вычислены (длина массива = 11)
            Assert.AreEqual(11, actual.Length, "Неправильная длина массива");
        }
    }
}