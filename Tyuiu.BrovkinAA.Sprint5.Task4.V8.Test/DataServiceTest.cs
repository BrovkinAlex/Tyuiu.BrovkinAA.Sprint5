using Tyuiu.BrovkinAA.Sprint5.Task4.V8.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"E:\Файлы с учебы\s5t4.txt";

            double res = ds.LoadFromDataFile(path);
            double wait = -23.071;

            Assert.AreEqual(wait, res);
        }
    }
}