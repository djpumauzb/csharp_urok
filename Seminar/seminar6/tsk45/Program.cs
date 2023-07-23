// Napishite programmu, kotoraya budet sozdavat' 
//kopiyu massiva s pomoshyu poelementnogo kopirovaniya

int[] ReArray(int[] array) 
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

int[] NewRandomArray(int size, int minValue, int maxValue)
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().Next(minValue, maxValue);
    return massiv;
}

int[] array = NewRandomArray(5, 1, 10);
int[] copy = ReArray(array);
Console.WriteLine($"[{string.Join(",", array)}] -> {string.Join(",", copy)}");