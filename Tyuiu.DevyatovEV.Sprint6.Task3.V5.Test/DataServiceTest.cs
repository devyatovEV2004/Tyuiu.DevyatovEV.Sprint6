using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint6.Task3.V5.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckThirdColumnSorting()
        {
            // Arrange
            var ds = new DataService();

            int[,] matrix = {
                { 30, -20, 7, -8, 9 },
                { 32, 17, -14, -7, 33 },
                { 19, -19, -13, 14, -20 },
                { 11, 30, -1, 26, 6 },
                { 30, -15, -20, -5, 15 }
            };

            // Act
            int[,] sorted = ds.Calculate(matrix);

            // Assert
            // Исходные значения третьего столбца: 7, -14, -13, -1, -20
            // После сортировки по возрастанию: -20, -14, -13, -1, 7

            int[] expectedThirdColumn = { -20, -14, -13, -1, 7 };
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expectedThirdColumn[i], sorted[i, 2], $"Несоответствие в строке {i} третьего столбца");
            }

            // Проверяем, что остальные столбцы не изменились
            Assert.AreEqual(30, sorted[0, 0], "Значение [0,0] изменилось");
            Assert.AreEqual(-20, sorted[0, 1], "Значение [0,1] изменилось");
            Assert.AreEqual(-8, sorted[0, 3], "Значение [0,3] изменилось");
            Assert.AreEqual(9, sorted[0, 4], "Значение [0,4] изменилось");
        }
    }
}