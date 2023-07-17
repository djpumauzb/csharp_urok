// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetDegree(int A, int B) 
{
    int result = A;
    for (int i = 2; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int numA = GetInfo("Vvedite cislo A: ");
int numB = GetInfo("Vvedite cislo B: ");

Console.WriteLine($"{numA}, {numB} -> {GetDegree(numA, numB)}");