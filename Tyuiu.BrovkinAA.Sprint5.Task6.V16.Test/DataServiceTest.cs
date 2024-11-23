using Tyuiu.BrovkinAA.Sprint5.Task6.V16.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V16.txt";

            int res = ds.LoadFromDataFile(path);
            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}