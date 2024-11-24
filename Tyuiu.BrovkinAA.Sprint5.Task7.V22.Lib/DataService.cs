using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BrovkinAA.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string saveFilePath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");
            if (File.Exists(saveFilePath))
                File.Delete(saveFilePath);

            string line;
            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        switch(c)
                        {
                            case '.':
                            case ',':
                            case '-':
                            case '(':
                            case ')':
                            case ':':
                            case ';':
                            case '!':
                            case '?':
                            case '"':
                                result += '#';
                                break;
                            default:
                                result += c;
                                break;
                        }
                    }
                }
            }

            File.WriteAllText(saveFilePath, result);
            return saveFilePath;
        }
    }
}
