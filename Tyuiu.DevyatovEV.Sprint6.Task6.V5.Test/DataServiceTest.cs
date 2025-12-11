using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.DevyatovEV.Sprint6.Task6.V5.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void CollectTextFromFile_FileNotFound()
        {
            // Arrange
            DataService ds = new DataService();

            // Act & Assert
            ds.CollectTextFromFile(@"C:\NonExistent\File.txt");
        }
    }
}