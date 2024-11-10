using Tyuiu.BrovkinAA.Sprint5.Task2.V3.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] ints = { { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 } };
            
            string str = ds.SaveToFileTextData(ints);
            string pathResult = @"C:\Users\Scree\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(pathResult);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}