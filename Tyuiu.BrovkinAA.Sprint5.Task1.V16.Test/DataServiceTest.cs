using Tyuiu.BrovkinAA.Sprint5.Task1.V16.Lib;
using static System.Formats.Asn1.AsnWriter;
namespace Tyuiu.BrovkinAA.Sprint5.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveDataFile()
        {
            DataService ds = new DataService();
            string strRes = ds.SaveToFileTextData(-5, 5);

            string[] pathstr = { "C:", "Users", "Scree", "AppData", "Local", "Temp", "OutPutFileTask1.txt" };
            string filePath = Path.Combine(pathstr);
            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
            Assert.IsTrue(fileExists);
        }
    }
}