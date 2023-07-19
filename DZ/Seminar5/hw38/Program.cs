// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int GetOddSum(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            summ = summ + array[i];
        }
    }
    return summ;
}

double[] NewRandomArray(int size, double minValue, double maxValue) // Pechataet randomnie massivi s opredelonnimi diapazonami
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().Next(minValue, maxValue);
    return massiv;
}
int[] array = NewRandomArray(4, -100, 100);

Console.Write($"[{string.Join(",", array)}] -> {GetOddSum(array)}");