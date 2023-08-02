// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillSpiralMassive(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    int value = 1;
    int top = 0;
    int bottom = rows - 1;
    int left = 0;
    int right = columns - 1;
    while (value <= rows * columns)
    {
        // Заполнение верхней строки слева направо
        for (int i = left; i <= right; i++)
        {
            result[top, i] = value++;
        }
        top++;

        // Заполнение правого столбца сверху вниз
        for (int i = top; i <= bottom; i++)
        {
            result[i, right] = value++;
        }
        right--;

        // Заполнение нижней строки справа налево
        for (int i = right; i >= left; i--)
        {
            result[bottom, i] = value++;
        }
        bottom--;

        // Заполнение левого столбца снизу вверх
        for (int i = bottom; i >= top; i--)
        {
            result[i, left] = value++;
        }
        left++;
    }
    return result;
}

void PrntDoDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]:D2} "); // Форматирование вывода для двузначных чисел
        }
        Console.WriteLine();
    }
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int rows = GetInfo("Vvedite kol strok massiva: ");
int columns = GetInfo("Vvedite kol stolbcov massiva: ");

int[,] resultSpiralMassive = FillSpiralMassive(rows, columns);
PrntDoDoubleMassive(resultSpiralMassive);
