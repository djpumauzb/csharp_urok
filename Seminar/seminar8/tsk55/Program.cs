// Zadayte dvumerniy massiv. Napishite programmu, kotoraya zemnyaet stroki na slolbci. 
// V sluchae, esli eto nevozmojno, programma doljna vivesti soobshenie dlya polzovatelya


void Swap(int[,] massive)
{
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);

    // Проверяем, можно ли поменять строки и столбцы местами
    if (rows != columns)
    {
        Console.WriteLine("Невозможно поменять строки и столбцы местами, так как количество строк и столбцов не совпадает."); // Из-за return; функция завершит свою работу, не возвращая значения.
    }
    else
    {

        // Создаем временный массив для хранения элементов при обмене
        int temp = 0;

        // Меняем строки и столбцы местами
        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < columns; j++) // Используем j = i + 1, чтобы избежать повторного обмена элементов
            {
                temp = massive[i, j];
                massive[i, j] = massive[j, i];
                massive[j, i] = temp;
            }
        }
        Console.WriteLine();
        PrntDoDoubleMassive(massive);
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
Swap(massive);
