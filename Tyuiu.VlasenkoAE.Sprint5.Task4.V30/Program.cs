using System.IO;
using Tyuiu.VlasenkoAE.Sprint5.Task4.V30.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V30.txt в котором есть      *");
Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо  *");
Console.WriteLine("* Х в формуле. Вычислить значение по формуле и вернуть полученный         *");
Console.WriteLine("* результат на консоль.                                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"С:\DataSprint5\InPutDataFileTask4V30.txt";
Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();