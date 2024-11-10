using Tyuiu.BrovkinAA.Sprint5.Task3.V6.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFile()
        {
            DataService ds = new DataService();
            ds.SaveToFileTextData(5);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists, wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}