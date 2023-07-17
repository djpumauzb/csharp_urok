// Napishite programmu, kotoraya prinimaet na vxod chislo N i vidaet 
// proizvedenie chisel 1 do N
// 4-> 24
// 5 -> 120

int ProdNums(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result = result * i;
    }
    return result;
}



int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Vvedite cislo: ");

Console.WriteLine($"{num} -> {ProdNums(num)}");
