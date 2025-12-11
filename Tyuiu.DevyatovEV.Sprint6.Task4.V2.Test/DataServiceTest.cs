using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint6.Task4.V2.Lib;
using System;

namespace Tyuiu.DevyatovEV.Sprint6.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFunctionValues()
        {
            // Arrange
            DataService ds = new DataService();

            // Act
            double[] result = ds.GetMassFunction(-5, 5);

            // Assert - проверяем несколько ключевых значений
            Assert.AreEqual(11, result.Length, "Неправильная длина массива");

            // Проверяем x = -5
            double x = -5;
            double expectedAtMinus5 = Math.Cos(x) / (x - 0.7) - Math.Sin(x) * 12 * x + 2;
            expectedAtMinus5 = Math.Round(expectedAtMinus5, 2, MidpointRounding.AwayFromZero);
            Assert.AreEqual(expectedAtMinus5, result[0], 0.01, $"Mismatch at x = {x}");

            // Проверяем x = 0
            x = 0;
            double expectedAt0 = Math.Cos(x) / (x - 0.7) - Math.Sin(x) * 12 * x + 2;
            expectedAt0 = Math.Round(expectedAt0, 2, MidpointRounding.AwayFromZero);
            Assert.AreEqual(expectedAt0, result[5], 0.01, $"Mismatch at x = {x}");

            // Проверяем x = 5
            x = 5;
            double expectedAt5 = Math.Cos(x) / (x - 0.7) - Math.Sin(x) * 12 * x + 2;
            expectedAt5 = Math.Round(expectedAt5, 2, MidpointRounding.AwayFromZero);
            Assert.AreEqual(expectedAt5, result[10], 0.01, $"Mismatch at x = {x}");

            // Проверяем, что при x = 0.7 (которого нет в диапазоне) не возникает ошибок
        }
    }
}