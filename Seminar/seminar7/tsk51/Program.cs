// Zadayte dvumerniy massiv. Naydite elemnti, nado podshitat summu po dioganali [0; 0] [1,1] [2,2]
// napriemr massiv viglyadet tak:          
// 1 4 7 2                                  
// 5 9 2 3                                  
// 8 4 2 4  
// Summa elementov glavnoy diagonali: 1 + 9 + 2 = 12

void DiagonalMassiveSumm(int[,] massive)
{
    int summ = 0;
    int size = massive.GetLength(1);
    if (massive.GetLength(0) < massive.GetLength(1))
    {
        size = massive.GetLength(0);
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{massive[i, i]} + ");
        summ += massive[i, i];
    }
    summ += massive[size - 1, size - 1];
    Console.WriteLine($"{massive[size - 1, size - 1]} = {summ}");
}

void PrntMassive(int[,] massive)
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

int[,] massive = DoDoubleMassive(rows, columns, 0, 10);
PrntMassive(massive);
Console.Write($"Summa po glavnoy diagonali: ");
DiagonalMassiveSumm(massive);
