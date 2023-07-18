// // naydite proizvedenie par chisel v odnomernom massive. 
// // Paroy schitaem perviy i posledniy element, vtoroy i predposledniy i t.d. 
// // Prezultat zapishite v novom massive
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21


int[] SimmetricSumm(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] arrayNew = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        arrayNew[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 == 1)
        arrayNew[size - 1] = array[array.Length / 2];
    return arrayNew;
}


int[] NewRandomArray(int size, int minValue, int maxValue) // Pechataet randomnie massivi s opredelonnimi diapazonami
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().Next(minValue, maxValue);
    return massiv;
}

int[] array = NewRandomArray(5, 0, 10);
int[] newArray = SimmetricSumm(array);
Console.WriteLine($"[{string.Join(",", array)}] -> {string.Join(" ", newArray)}");