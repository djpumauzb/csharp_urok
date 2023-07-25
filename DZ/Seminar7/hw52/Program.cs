// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AvarageColumns(int[,] massive, int rows, int columns)
{
    string result = "";
    for (int i = 0; i < columns; i++)
    {
        int summ = 0;
        for (int j = 0; j < rows; j++)
        {
            summ += massive[j, i];
        }
        double average = (double)summ / rows;
        result += average.ToString("0.#", System.Globalization.CultureInfo.InvariantCulture);
        if (i < columns - 1) result += "; ";
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {result}.");
}

void PrntDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GenDoublMassv(int rows, int columns, int minValue, int maxValue)
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

int[,] massive = GenDoublMassv(rows, columns, 1, 10);
PrntDoubleMassive(massive);
Console.WriteLine();
AvarageColumns(massive, rows, columns);