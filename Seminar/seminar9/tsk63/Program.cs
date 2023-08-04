// Zadayte znachnie N. Napishite programmu, kotoraya viviedet vse 
// naturalnie chisla v promejutka ot 1 do N.
// N = 5 -> "1,2,3,4,5"
// N = 6 -> "1,2,3,4,5,6"

void NaturalNumber(int N)
{
    Console.Write($"{N} -> ");
    for (int i = 1; i <= N; i++)
    {
        Console.Write($"{i}");
        if (i < N)
        {
            Console.Write(",");
        }
    }
}


int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int N = GetInfo("Vvedite znachenie N: ");
NaturalNumber(N);

