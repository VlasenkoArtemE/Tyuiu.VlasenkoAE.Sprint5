using Tyuiu.VlasenkoAE.Sprint5.Task1.V22.Lib;

int startValue = -5;
int stopValue = 5;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана функция f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести   *");
Console.WriteLine("* проверку деления на ноль. При делении на ноль вернуть значение 0.       *");
Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на   *");
Console.WriteLine("* консоль в таблицу. Значения округлить до двух знаков после запятой.     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("startValue = " + startValue);
Console.WriteLine("stopValue = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(startValue, stopValue);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();