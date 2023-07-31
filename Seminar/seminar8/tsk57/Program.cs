// Sostavit chastotniy slovaer elementov dvumernogo massiva.
// chastotniy slovaer soderjit informatciyu o tom, 
// skolko raz vstrechaetsya element vxodnix dannix

// {1, 9, 9, 0, 2, 8, 0, 9}
// 0 vstrecahetsya 2 raza
// 1 vstrecahetsya 1 raz
// 2 vstrecahetsya 1 raz
// 8 vstrecahetsya 1 raz
// 9 vstrecahetsya 3 raza 

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 vstrecahetsya 3 raza
// 2 vstrecahetsya 2 raz
// 3 vstrecahetsya 1 raz
// 4 vstrecahetsya 1 raz
// 6 vstrecahetsya 2 raza 



void GetDigit(int[,] massive)
{
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
    // Проверяем, является ли массив одномерным (содержит только одну строку)
    if (rows == 1)
    {
        for (int k = 0; k < columns; k++)
        {
            int count = 0;
            for (int j = 0; j < columns; j++)
            {
                if (massive[0, j] == k) count++;
            }
            if (count != 0) Console.WriteLine($"{k} встречается {count} раз");
        }
    }
    else
    {
        for (int k = 0; k < massive.Length; k++)
        {
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (massive[i, j] == k) count++;
                }
            }
            if (count != 0) Console.WriteLine($"{k} встречается {count} раз");
        }
    }
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
GetDigit(massive);