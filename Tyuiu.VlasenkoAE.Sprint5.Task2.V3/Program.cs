using Tyuiu.VlasenkoAE.Sprint5.Task2.V3.Lib;

int[,] mtrx = new int[3, 3] { { 5, 9, 1 },
                              { 1, 3, 9 },
                              { 1, 2, 2 } } ;

int rows = mtrx.GetUpperBound(0) + 1;   // количество строк
int columns = mtrx.Length / rows;       // количество столбцов

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");    //write для того, чтобы вывод был корректным
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(mtrx);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
