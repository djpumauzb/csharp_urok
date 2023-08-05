// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalNumber(int M, int N)
{
    if (M > N) // Базовый случай, если M больше N, то возвращаем 0.
    {
        return 0;
    }
    else
    {
        int result = M + NaturalNumber(M + 1, N); // Рекурсивный вызов с увеличением M на 1.
        return result;
    }
}


int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int M = GetInfo("Vvedite znachenie M: ");
int N = GetInfo("Vvedite znachenie N: ");

int result = NaturalNumber(M, N);
Console.WriteLine($"M = {M}; N = {N} -> {result} ");