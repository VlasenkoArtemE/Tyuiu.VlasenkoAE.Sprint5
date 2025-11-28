using System.Diagnostics.CodeAnalysis;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VlasenkoAE.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double sum = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    for (int i = 0; i < values.Length; i++)
                    {
                        double x = Convert.ToDouble(values[i]);
                        if (x >= 0)
                        {
                            sum += x;
                            count++;
                        }
                    }
                }
            }
            res = Math.Round((sum / count), 3);
            return res;
        }
    }
}
