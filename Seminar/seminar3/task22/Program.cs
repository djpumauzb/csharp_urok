// Napishite pogrammu, kotoraya prinimaet na chislo (N) i vidaet tablicu kvadratov chisel
// ot 1 do N

// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4



string DefSqr(int num)
{
    string result = "";
    Console.Write($"{num} -> ");
    int i = 1;
    int Resul2 = 0;
    while (i < num)
    {
        result += $"{i * i}, ";
        i++;
    }
    if (num == i)
    {
        Resul2 = (i * i);
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
Console.WriteLine(DefSqr(num));
