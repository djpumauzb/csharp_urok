// Ne ispolzuya rekursiyu, vivedite pervie N chisel Fibonachi.
// Pervie dva chisla Fibonachi: 0 i 1
// Esli N = 5 -> 01123
// Esli N = 3 -> 011
// Esli N = 7 -> 0112358

int[] DefRec(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

void Fibonachi(int num) // the another better way
{
    double num1 = 0;
    double num2 = 1;
    double num3 = 0;
    Console.Write($"{num} -> 0 1");
    for (int i = 2; i < num; i++)
    {
        num3 = num1 + num2;
        Console.Write($"{num3}");
        num1 = num2;
        num2 = num3;
    }
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Vvedite chislo: ");
int[] recursion = DefRec(num);
Console.WriteLine($"N = {num} -> {string.Join(" ", recursion)}");

