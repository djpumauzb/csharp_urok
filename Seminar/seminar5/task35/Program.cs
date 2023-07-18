// Zadayte odnomerniy massiv iz 123 sluchaynix chisel. Naydite kolichestvo elementov massiva,
// znacheniya kotorix lejat v otrezke [10,99]
// Primer dlya massiva iz 5, a ne 123 elementov. V svoem reshenii sdelayte dlya 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] NewRandomArray(int size, int minValue, int maxValue) // Pechataet randomnie massivi s opredelonnimi diapazonami
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().Next(minValue, maxValue);
    return massiv;
}

int DefCount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 & array[i] <= 99)
        {
            result++;
        }
    }
    return result;
}

int[] array = NewRandomArray(123, 0, 140);

Console.Write($"[{string.Join(",", array)}] -> {DefCount(array)}");