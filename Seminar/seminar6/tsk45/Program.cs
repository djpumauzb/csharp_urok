// Napishite programmu, kotoraya budet sozdavat' 
//kopiyu massiva s pomoshyu poelementnogo kopirovaniya

void ReArray(int[] array) 
{
    int copy = 0;
    for (int i = 0; i < array.Length; i++)
    {
       copy = array[i];
       Console.Write(copy);
    }
}






int[] NewRandomArray(int size, int minValue, int maxValue)
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().Next(minValue, maxValue);
    return massiv;
}

int[] array = NewRandomArray(5, 1, 10);
int[] reArray = ReArray(array);
Console.Write($"[{string.Join(",", array)}] -> {reArray} ");