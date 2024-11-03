using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.BrovkinAA.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            double result = (double)x / (Math.Pow(x, 3) + 2);
            result = Math.Round(result, 3);

            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask0.txt");
            File.WriteAllText(path, result.ToString());

            return path;
        }
    }
}
