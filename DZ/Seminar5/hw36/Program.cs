// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int[] NewRandomArray(int size, int minValue, int maxValue) // Pechataet randomnie massivi s opredelonnimi diapazonami
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().Next(minValue, maxValue);
    return massiv;
}
int[] array = NewRandomArray(4, -100, 100);

Console.Write($"[{string.Join(",", array)}] -> {GetOddSum(array)}");