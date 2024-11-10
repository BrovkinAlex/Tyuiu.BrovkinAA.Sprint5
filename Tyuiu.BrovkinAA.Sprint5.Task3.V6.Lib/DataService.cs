using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BrovkinAA.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            if (File.Exists(path)) File.Delete(path);

            double res;
            if ((x * x + x) == 0)
                res = 0;
            else
                res = Math.Round((x / Math.Sqrt(x * x + x)), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }

            return path;
        }
    }
}
