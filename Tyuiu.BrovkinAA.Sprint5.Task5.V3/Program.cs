using System.Globalization;
using Tyuiu.BrovkinAA.Sprint5.Task5.V3.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task5.V3
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
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                              *");
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #3                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Прочитать значения из файла. Найти сумму всех целых чисел в файле.           *");
            Console.WriteLine("* Полученный результат вывести на консоль.                                    *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine(@"Файл: C:\DataSprint5\InPutDataFileTask5V3.txt" + "\n");
            Console.WriteLine("Содeржимое файла: ");
            using (StreamReader rs = new StreamReader(@"C:\DataSprint5\InPutDataFileTask5V3.txt"))
            {
                Console.WriteLine(rs.ReadLine() + "\n");
            }
            double res = ds.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask5V3.txt");
            Console.WriteLine("Результат: " + res);

            Console.ReadKey();
        }
    }
}
