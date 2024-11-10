using Tyuiu.BrovkinAA.Sprint5.Task3.V6.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 5 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #5                                                                   *");
            Console.WriteLine("* Тема: Класс File. Потоковый метод записи данных в бинарный файл             *");
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #6                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дано выражение, вычислить его значение при х = 3, результат сохранить       *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin                                         *");
            Console.WriteLine("* Округлить до трех знаков после запятой.                                     *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("                x");
            Console.WriteLine("      y =  ----------");
            Console.WriteLine("           √(x^2 + x)");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            int x = 3;
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
