using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BrovkinAA.Sprint5.Task2.V3.Lib
{
    public class DataService : ISprint5Task2V3
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string pathToSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            if (File.Exists(pathToSaveFile)) File.Delete(pathToSaveFile);

            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        matrix[i, j] = 0;

                    File.AppendAllText(pathToSaveFile, matrix[i, j].ToString());
                    if (j != matrix.GetUpperBound(1))
                        File.AppendAllText(pathToSaveFile, ",\t");
                }
                File.AppendAllText(pathToSaveFile, "\n");
            }

            return pathToSaveFile;
        }
    }
}
