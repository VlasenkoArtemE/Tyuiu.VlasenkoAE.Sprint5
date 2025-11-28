using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VlasenkoAE.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(' ');
                    for (int i = 0; i < values.Length; i++)
                    {
                        string x = values[i];
                        if (x.Length == 8)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
