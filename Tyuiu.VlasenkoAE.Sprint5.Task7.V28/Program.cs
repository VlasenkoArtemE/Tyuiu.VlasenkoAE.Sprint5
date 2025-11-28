using Tyuiu.VlasenkoAE.Sprint5.Task7.V28.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #28                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V28.txt в котором есть      *");
Console.WriteLine("* набор символьных данных. Заменить все пробелы, идущие подряд более      *");
Console.WriteLine("* одного, на один пробел. Полученный результат сохранить в файл           *");
Console.WriteLine("* OutPutDataFileTask7V28.txt.                                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask7V28.txt";
Console.WriteLine("Данные находятся в файле: " + path);

string pathSave = @"C:\Users\artem\AppData\Local\Temp\OutPutFileTask7.V28.txt";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

pathSave = ds.LoadDataAndSave(path);
Console.WriteLine("Находится в файле: " + pathSave);

Console.ReadKey();