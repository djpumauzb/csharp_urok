// Zadayte dvumerniy massiv. Napishite programmu, kotoraya 
// pomenyaet mestami pervuyu i polednuyu stroku massiva.


void ReverceMassive(int[,] massive)
{
    int columns = massive.GetLength(0); // Получаем количество столбцов
    int rows = massive.GetLength(1); // Получаем количество строк
    int temp = 0;
    for (int i = 0; i < rows; i++) // Используем rows для обхода по строкам
    {
        temp = massive[0, i];
        massive[0, i] = massive[columns - 1, i]; // Меняем местами первую и последнюю строки
        massive[columns - 1, i] = temp;
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

int[,] massive = DoDoubleMassive(rows, columns, 1, 10);
PrntDoDoubleMassive(massive);
Console.WriteLine();
ReverceMassive(massive);
PrntDoDoubleMassive(massive);