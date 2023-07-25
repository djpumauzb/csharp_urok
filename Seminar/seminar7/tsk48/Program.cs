// Zadayte dvumerniy massiv razmera m na n,
// kajdiy element v massive naxoidtsya po formule: A(mn) = i + j.
// Vvedite poluchenniy massiv na ekran.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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

int[,] DoDoubleMassive(int rows, int columns)
{
    int[,] result = new int[rows, columns]; //vot ono kak rabotaet ) 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = i + j;
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
int[,] massive = DoDoubleMassive(rows, columns);  // [,] dvumerniy massiv [,,,,] - pyatimerniy massiv
PrntDoDoubleMassive(massive);