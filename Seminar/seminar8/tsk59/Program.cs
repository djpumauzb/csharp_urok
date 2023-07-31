// Zadayte dvumerniy massiv iz celix chisel.
// Napishite programmu, kotoraya udalit stroku i stolbec, 
// na peresechenii kotorix raspolojen naimenshiy element massiva
// naprimer zadan massiv:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Naimenshiy element - 1, na vixode poluchim sleduyushiy massiv:
// 9 4 2
// 2 2 6
// 3 4 7 




int[,] DeleteMin(int[,] massive)
{
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
    int minRows = 0;
    int minColumns = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (massive[i, j] < massive[minRows, minColumns])
            {
                minRows = i;
                minColumns = j;
            }
        }
    }
    Console.WriteLine($"Minimalnoe chislo {massive[minRows, minColumns]}, po adresu [{minRows}, {minColumns}]");
    int countRows = 0;
    int countColumns = 0;
    int[,] newMassive = new int[rows - 1, columns - 1];
    for (int i = 0; i < rows; i++)
    {
        countColumns = 0;
        for (int j = 0; j < columns; j++)
        {
            if (j == minColumns)
            {
                countColumns = 1;
                continue;
            }
            newMassive[i - countRows, j - countColumns] = massive[i, j];
        }
        if (i == minRows)
        {
            countRows = 1;
            continue;
        }
    }
    return newMassive;
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
Console.WriteLine();
DeleteMin(massive);
PrntDoDoubleMassive(massive);