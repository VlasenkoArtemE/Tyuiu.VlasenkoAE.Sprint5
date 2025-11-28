using Tyuiu.VlasenkoAE.Sprint5.Task5.V2.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V2.txt в котором есть       *");
Console.WriteLine("* набор значений. Найти среднее всех положительных значений. Полученный   *");
Console.WriteLine("* результат вывести на консоль. У вещественных значений округлить до трёх *");
Console.WriteLine("* знаков после запятой.                                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask5V2.txt";
Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();