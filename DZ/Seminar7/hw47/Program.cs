// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void PrntDoubleMassive(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            // string doubleFormatInput = string.Format("{0:N1}", massive[i, j]);
            // Console.Write($"{doubleFormatInput} ");
            string formattedNumber = massive[i, j].ToString("0.#", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write($"{formattedNumber} ");
        }
        Console.WriteLine();
    }
}

double[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = minValue + (maxValue - minValue) * new Random().NextDouble();
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

double[,] massive = DoDoubleMassive(rows, columns, -10, 10);
PrntDoubleMassive(massive);