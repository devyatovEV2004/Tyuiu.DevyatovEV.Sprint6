using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.DevyatovEV.Sprint6.Task5.V29.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_Test()
        {
            // Arrange
            string testPath = Path.Combine(Path.GetTempPath(), "TestFileTask5V29.txt");

            // Тестовые данные - смешанные числа
            string testData = "5.67 12.345 8.9 15.789\n" +
                              "20.1 7.3 9.99 10.001\n" +
                              "14.256 3.14 25.67";
            File.WriteAllText(testPath, testData);

            // Act
            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(testPath);

            // Assert
            double[] expected = new double[]
            {
                5.670, 12.345, 8.900, 15.789,
                20.100, 7.300, 9.990, 10.001,
                14.256, 3.140, 25.670
            };

            CollectionAssert.AreEqual(expected, result);

            // Cleanup
            File.Delete(testPath);
        }
    }
}