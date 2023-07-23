// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int[] GetNumbersFromUser(int size)  
{
    int[] numbers = new int[size];
    Console.WriteLine("Введите числа по одному:");
    for (int i = 0; i < size; i++)
    {
        numbers[i] = GetInfo($"Число {i + 1} из {size}: ");
    }
    return numbers;
}

int CountPositiveNumbers(int[] numbers)
{
    int positiveCount = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            positiveCount++;
        }
    }
    return positiveCount;
}

int size = GetInfo("Введите количество чисел M: ");
int[] numbersArray = GetNumbersFromUser(size);
int positiveCount = CountPositiveNumbers(numbersArray);

string numbersAsString = string.Join(", ", numbersArray);
Console.WriteLine($"{numbersAsString} -> {positiveCount}");