// Zadayte dvumerniy massiv, Naydite elementi, u kotorix oba indeksa nechetnie,
// i zemenite eti elementi na ix kvadrti
// napriemr massiv viglyadet tak:           // Noviy budet viglyadet vot tak:
// 1 4 7 2                                  // 1 4 7 2
// 5 9 2 3                                  // 5 81 2 9
// 8 4 2 4                                  // 8 4 2 4



void ResultOddSqrMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                massive[i, j] = Convert.ToInt32(Math.Pow(massive[i, j], 2));
            }
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrntMassive(int[,] massive)
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
PrntMassive(massive);
Console.WriteLine();
ResultOddSqrMassive(massive);


