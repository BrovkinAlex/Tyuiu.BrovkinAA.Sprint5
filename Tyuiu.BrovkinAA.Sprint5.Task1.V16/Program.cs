using Tyuiu.BrovkinAA.Sprint5.Task1.V16.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task1.V16
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
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                     *");
            Console.WriteLine("* Задание #1                                                                  *");
            Console.WriteLine("* Вариант #16                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дана функция f(x) на заданном диапазоне [-5; 5] с шагом 1.                  *");
            Console.WriteLine("* При делении на 0 вернуть значение 0                                         *");
            Console.WriteLine("* в текстовый файл OutPutFileTask1.txt и вывести на консоль.                  *");
            Console.WriteLine("* Округлить до двух знаков после запятой.                                     *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("                     2x");
            Console.WriteLine("   F(x) = sin(x)  +  --  -  cos(x) * 4x");
            Console.WriteLine("                     3");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            int x = 3;
            string res = ds.SaveToFileTextData(-5, 5);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
