// Zadacha 24: Napishite programmi, kotoraya prinimaet na vxod chislo (A)
// i vidaet summi chisel ot 1 do A
// 7 -> 28
// 4 -> 10
// 8 -> 36


int GetSum(int limit)
{
    int sum = 0;
    for (int i = 0; i <= limit; i++)
    {
        sum += i;
    }
    return sum;
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int A = GetInfo("Vvedite cislo A: ");

Console.WriteLine($"Summa chisel ot odnogo do {A} = {GetSum(A)}");