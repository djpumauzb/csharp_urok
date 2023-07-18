// Napishite programmu zamena elementov massiva: polojitel'nie elementi 
// zamenite na sootv etstvuyushie otricatelnie, i nabarot
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] RevercedArray(int[] array) // reverce array
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = -array[i];
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
int[] revercedArray = RevercedArray(array);

Console.WriteLine($"[{string.Join(",", array)}] -> [{string.Join(",", revercedArray)}]");