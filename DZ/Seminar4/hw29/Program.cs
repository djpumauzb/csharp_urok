// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] AddArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GetInfo($"Введите элемент {i + 1}: ");
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}


int size = 8;
int[] nums = AddArray(size);
PrintArray(nums);