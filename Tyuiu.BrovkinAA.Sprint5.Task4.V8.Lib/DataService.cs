using System.Globalization;
using System.Runtime.Serialization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BrovkinAA.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            string strNum = File.ReadAllText(path);
            double numFromFile = double.Parse(strNum, formatter);

            double res;
            if (numFromFile == 0)
                res = 3;
            else
                res = Math.Pow(numFromFile, 2) / Math.Sin(numFromFile) + 3;

            return Math.Round(res ,3);
        }
    }
}
