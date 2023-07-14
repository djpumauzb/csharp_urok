// tsk2
// poryadka po ocheredi v massive


int[] arr = {1, 5, 4, 1, 6, 7, 1, 8};

void PrntArr(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


void SelectSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] < arr[minPos]) minPos = j;
        }
        int temporary = arr[i];
        arr[i] = arr[minPos];
        arr[minPos] = temporary;
    }
}


PrntArr(arr);
SelectSort(arr);

PrntArr(arr);