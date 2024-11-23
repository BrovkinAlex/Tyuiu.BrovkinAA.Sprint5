using Tyuiu.BrovkinAA.Sprint5.Task5.V3.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V3.txt";
            double res = ds.LoadFromDataFile(path);
            double wait = 35;

            Assert.AreEqual(wait, res);
        }
    }
}