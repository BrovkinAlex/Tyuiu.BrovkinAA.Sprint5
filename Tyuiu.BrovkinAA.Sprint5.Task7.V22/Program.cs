using Tyuiu.BrovkinAA.Sprint5.Task7.V22.Lib;
namespace Tyuiu.BrovkinAA.Sprint5.Task7.V22
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
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                              *");
            Console.WriteLine("* Задание #7                                                                  *");
            Console.WriteLine("* Вариант #22                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Взять файл в котором есть набор символьных данных.                          *");
            Console.WriteLine("* Заменить все знаки препинания на #.                                         *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V22.txt.           *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine(@"Файл: C:\DataSprint5\InPutDataFileTask7V22.txt" + "\n");
            Console.WriteLine("Содeржимое файла: ");
            using (StreamReader rs = new StreamReader(@"C:\DataSprint5\InPutDataFileTask7V22.txt"))
            {
                Console.WriteLine(rs.ReadLine() + "\n");
            }

            string res = ds.LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V22.txt");
            Console.Write("\nРезультат: ");
            if (File.Exists(res))
                Console.WriteLine($"файл {res} успешно создан!");
            else
                Console.WriteLine("Какая-то ошибка :(");

            Console.ReadKey();
        }
    }
}
