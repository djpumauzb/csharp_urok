// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


void NumRowOfMinSumm(int [,] massive)
{
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
    int[] summRow = new int[rows];
    int minSumm = massive[0,0];
    int rowNum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            summRow[i] += massive[i, j];

        }
        if (i == 0 || summRow[i] < minSumm) {
            minSumm = summRow[i];
            rowNum = i + 1;
        }
    }
    Console.WriteLine($"Наименьшей суммой элементов: {rowNum} строка");
}



void PrntDoDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++) // novaya funksiya dlya dvuxmernix massivax
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int rows = GetInfo("Vvedite kol strok massiva: ");
int columns = GetInfo("Vvedite kol stolbcov massiva: ");

int[,] massive = DoDoubleMassive(rows, columns, 0, 10);
PrntDoDoubleMassive(massive);
NumRowOfMinSumm(massive);