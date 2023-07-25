// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void CheckNumMassive(int[,] massive, int checknum)
{
    bool numFound = false;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (checknum == massive[i, j])
            {
                Console.WriteLine($"Takogo chisa est v massive: stroka: {i + 1}, stolbec: {j + 1}");
                numFound = true;
                break;
            }
        }
        if (numFound) break;
    }

    if (!numFound)
    Console.WriteLine($"{checknum} -> такого числа в массиве нет");
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
int checknum = GetInfo("Vvedite chislo kotoroe xotite iskat' v massive: ");

int[,] massive = GenDoublMassv(rows, columns, 1, 10);
PrntDoubleMassive(massive);
CheckNumMassive(massive, checknum);