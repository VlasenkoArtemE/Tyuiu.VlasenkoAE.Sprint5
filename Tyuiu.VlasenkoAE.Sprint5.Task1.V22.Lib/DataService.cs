using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VlasenkoAE.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 2)
                {
                    y = Math.Sin(x) + 2 * x;
                }
                else
                {
                    y = Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;
                }
                
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }      
    }
}
