using Tyuiu.BrovkinAA.Sprint5.Task2.V3.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task2.V3
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
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл          *");
            Console.WriteLine("* Задание #2                                                                  *");
            Console.WriteLine("* Вариант #3                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный            *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.           *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask2.csv                    *");
            Console.WriteLine("* и вывести на консоль.                                                       *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            int[,] matrix = { { 5, 9, 1 }, 
                              { 1, 3, 9 }, 
                              { 1, 2, 2 } };

            Console.WriteLine("Дан массив:");
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    if (j == matrix.GetUpperBound(1))
                        Console.Write(matrix[i, j] + "\n");
                    else
                        Console.Write(matrix[i, j] + ",\t");
                }

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");
                        
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
