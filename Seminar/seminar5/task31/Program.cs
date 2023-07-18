// Zadacha 31: Zadayte iz 12 elementov, zapolnennoy sluchaynimi chislami iz promejutka [-9, 9].
// Haydite summu otricatel'nix i polojitelnix elementov massiva.
// Naprimer, v massive [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] summa polojitelnix chisel ravna 29, summa otricatelnix ravna na -20.

int GetPosOrNegativeSum(int[] array, bool posOrNegative) // Vozvrasahet summu otricatelnuyu ili nmegativnuyu summu
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (posOrNegative)
        {
            if (array[i] > 0) result += array[i];
        }
        else if (array[i] < 0) result += array[i];
    }
    return result;
}

int[] NewRandomArray(int size, int minValue, int maxValue) // Pechataet randomnie massivi s opredelonnimi diapazonami
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().Next(minValue, maxValue);
    return massiv;
}

int[] array = NewRandomArray(12, -9, 9);

Console.WriteLine($"[{string.Join(",", array)}]");
Console.Write($"Summ of positive numbers equal to {GetPosOrNegativeSum(array, true)}, ");
Console.Write($"summ of negative numbers equal to {GetPosOrNegativeSum(array, false)}.");