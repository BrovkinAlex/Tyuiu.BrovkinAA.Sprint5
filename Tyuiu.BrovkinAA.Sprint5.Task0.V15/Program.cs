using Tyuiu.BrovkinAA.Sprint5.Task0.V15.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task0.V15
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
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                            *");
            Console.WriteLine("* Задание #0                                                                  *");
            Console.WriteLine("* Вариант #15                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить        *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.                  *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                     *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("              x");
            Console.WriteLine("   y(x) = ---------");
            Console.WriteLine("           x^3 + 2");

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
