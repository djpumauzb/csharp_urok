// Napishite programmu, kotoraya perevernet odnomerniy massiv 
// (posledniy element budet na pervom meste,a perviy - na poslednem i t.d.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] ReversedArray(int[] array)
{
    int temp = array[0];
    array[0] = array[array.Length-1];
    array[array.Length-1] = temp;
}




int[] NewRandomArray(int size, int minValue, int maxValue)
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().Next(minValue, maxValue);
    return massiv;
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}


int size = GetInfo("Vvedite rezmer massiva: ");
int[] array = NewRandomArray(size, 1, 10);
ReversedArray(array);