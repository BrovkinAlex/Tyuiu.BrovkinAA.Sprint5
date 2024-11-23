using System.Globalization;
using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BrovkinAA.Sprint5.Task5.V3.Lib
{
    public class DataService : ISprint5Task5V3
    {
        public double LoadFromDataFile(string path)
        {
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            double res = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                if (line != null)
                {                    
                    foreach (string strNum in line.Split(' '))
                    {
                        double num = double.Parse(strNum, formatter);
                        if (num == Math.Round(num))
                            res += num;
                    }
                }
            }

            return res;
        }
    }
}
