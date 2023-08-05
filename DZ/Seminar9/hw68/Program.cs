// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Acker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Acker(m - 1, 1);
    }
    else
    {
        return Acker(m - 1, Acker(m, n - 1));
    }
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int m = GetInfo("Vvedite znachenie m: ");
int n = GetInfo("Vvedite znachenie n: ");

int result = Acker(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");