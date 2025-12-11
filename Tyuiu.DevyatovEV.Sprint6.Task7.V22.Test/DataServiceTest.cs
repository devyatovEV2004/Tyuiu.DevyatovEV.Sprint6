using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.DevyatovEV.Sprint6.Task7.V22.Lib;

namespace Tyuiu.DevyatovEV.Sprint6.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private string testFilePath = Path.Combine(Path.GetTempPath(), "TestMatrixV22.csv");

        [TestInitialize]
        public void Setup()
        {
            File.WriteAllLines(testFilePath, new string[]
            {
                "12;7;0;-9;4;5;7;-10;-12;-5",
                "10;16;2;-9;-7;5;-14;-9;-9;2",
                "17;-9;20;-19;-14;-12;12;-19;-9;-13",
                "19;6;-16;-15;3;20;5;-1;-17;8",
                "-12;17;18;8;-16;-20;-3;-18;16;16",
                "13;-6;-9;3;20;-5;6;16;-2;-7",
                "19;-3;8;-17;7;1;13;-7;17;0",
                "-8;6;-16;-5;-16;-8;-20;-16;9;-1",
                "3;8;-13;-19;11;20;14;-13;0;16",
                "6;3;7;7;5;-6;-18;-14;-13;13"
            });
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testFilePath)) File.Delete(testFilePath);
        }
        [TestMethod]
        public void ProcessMatrix_CheckOtherColumnsNotChanged()
        {
            var ds = new DataService();

            var matrix = ds.GetMatrix(testFilePath);
            var processed = ds.ProcessMatrix(matrix);

            Assert.AreEqual(12, processed[0, 0]);
            Assert.AreEqual(7, processed[0, 1]);
            Assert.AreEqual(0, processed[0, 2]);
            Assert.AreEqual(-9, processed[0, 3]);
            Assert.AreEqual(4, processed[0, 4]);
            Assert.AreEqual(7, processed[0, 6]);
            Assert.AreEqual(-10, processed[0, 7]);
            Assert.AreEqual(-12, processed[0, 8]);
            Assert.AreEqual(-5, processed[0, 9]);
        }
    }
}