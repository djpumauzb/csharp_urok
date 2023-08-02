// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Для умножения двух матриц, необходимо выполнить операцию умножения
// строк первой матрицы на столбцы второй матрицы и записать результаты 
// в новую матрицу.
// Пусть у нас есть две матрицы:
// A = | a1.1 a1.2 |
//     | a2.1 a2.2 |

// B = | b1.1 b1.2 |
//     | b2.1 b2.2 |

// Тогда результирующая матрица C будет:
// C = | a1.1b1.1 + a1.2b2.1 a1.1b1.2 + a1.2b2.2 |
//     | a2.1b1.1 + a2.2b2.1 a2.1b1.2 + a2.2b2.2 |

void MultiplyMatrices(int[,] massive1, int[,] massive2)
{
    int rows1 = massive1.GetLength(0);
    int columns1 = massive1.GetLength(1);
    int rows2 = massive2.GetLength(0);
    int columns2 = massive2.GetLength(1);
    // Проверяем, возможно ли выполнить умножение матриц
    if (columns1 != rows2)
    {
        Console.WriteLine("Невозможно выполнить умножение матриц: неправильные размеры.");
        Console.WriteLine("Количество столбцов в первой матрице должно быть равно количеству строк второй матрицы");
    }
    else
    {
        // Создаем результирующую матрицу
        int[,] resultMassive = new int[rows1, columns2];

        // Выполняем умножение матриц
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                resultMassive[i, j] = 0;
                for (int k = 0; k < columns1; k++)
                {
                    resultMassive[i, j] += massive1[i, k] * massive2[k, j];
                }
            }
        }
        Console.WriteLine("Результирующая матрица будет:");
        PrntDoDoubleMassive(resultMassive);
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

int[,] massive = DoDoubleMassive(rows, columns, 2, 4);
int[,] massive2 = DoDoubleMassive(rows, columns, 2, 4);
PrntDoDoubleMassive(massive);
Console.WriteLine();
PrntDoDoubleMassive(massive2);
MultiplyMatrices(massive, massive2);