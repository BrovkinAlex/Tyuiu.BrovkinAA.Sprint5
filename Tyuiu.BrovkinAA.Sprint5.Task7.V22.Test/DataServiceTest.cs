using Tyuiu.BrovkinAA.Sprint5.Task7.V22.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadAndSave()
        {
            DataService ds = new DataService();
            string resPath = ds.LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V22.txt");
            bool fileExists = File.Exists(resPath);
            
            Assert.IsTrue(fileExists);
        }
    }
}