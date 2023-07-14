// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string DefKub(int num)
{
    string result = "";
    Console.Write($"{num} -> ");
    int i = 1;
    int Resul2 = 0;
    while (i < num)
    {
        result += $"{i * i * i}, ";
        i++;
    }
    if (num == i)
    {
        Resul2 = (i * i * i);
    }
    return result + Resul2;
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Vvedite chislo N: ");
Console.WriteLine(DefKub(num));
