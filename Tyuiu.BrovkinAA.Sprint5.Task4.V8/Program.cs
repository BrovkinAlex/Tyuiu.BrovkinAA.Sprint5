using System.Globalization;
using Tyuiu.BrovkinAA.Sprint5.Task4.V8.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task4.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            DataService ds = new DataService();          

            Console.Title = "Спринт 5 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #5                                                                   *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                     *");
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #8                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле                 *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить                *");
            Console.WriteLine("* до трёх знаков после запятой) и вернуть полученный результат на консоль.    *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("            x^2");
            Console.WriteLine("      y =  ------ + 3");
            Console.WriteLine("           sin(x)");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("Значение Х: " + double.Parse(File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask4V8.txt"), formatter));
            double res = ds.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask4V8.txt");
            Console.WriteLine("Результат: " + res);

            Console.ReadKey();
        }
    }
}
