using Tyuiu.BrovkinAA.Sprint5.Task0.V15.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveDataFile()
        {
            DataService ds = new DataService();
            string strRes = ds.SaveToFileTextData(3);
            string path = @"C:\Users\Scree\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}