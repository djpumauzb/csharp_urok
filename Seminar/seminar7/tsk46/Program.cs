// Zadayte dvumerniy massiv pazmerom m*n, zapolnenniy sluchaynimi celimi chislami
// m = 3, n = 4
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void PrntDoDoubleMassive(int[,] massive)
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

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns]; //vot ono kak rabotaet ) 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
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
int[,] massive = DoDoubleMassive(rows, columns, 0, 10);  // [,] dvumerniy massiv [,,,,] - pyatimerniy massiv
PrntDoDoubleMassive(massive);