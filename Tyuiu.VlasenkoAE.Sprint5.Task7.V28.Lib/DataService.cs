using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VlasenkoAE.Sprint5.Task7.V28.Lib
{
    public class DataService : ISprint5Task7V28
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V28.txt");

            FileInfo fileinfo = new FileInfo(pathSave);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSave);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int check = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ' ' && check == 0)
                        {
                            check++;
                            strLine += line[i];
                        }
                        else if (line[i] == ' ' && check == 1)
                        {
                            check = 0;
                        }
                        else
                        {
                            strLine += line[i];
                        }
                    }

                    File.AppendAllText(pathSave, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSave;
        }
    }
}
