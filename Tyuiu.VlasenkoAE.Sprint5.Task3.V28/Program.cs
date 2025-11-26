using Tyuiu.VlasenkoAE.Sprint5.Task3.V28.Lib;

int x = 3;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #28                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение, вычислить его значение при x = 3, результат сохранить   *");
Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль.               *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("x = " + x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(x);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
