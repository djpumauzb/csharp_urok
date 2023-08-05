// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NaturalNumber(int N)
{
    if (N > 1)
    {
        return $"{N}, {NaturalNumber(N - 1)}";
    }
    else return Convert.ToString(1);
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int N = GetInfo("Vvedite znachenie N: ");

string result = NaturalNumber(N);
Console.WriteLine($"N = {N} -> {result} ");