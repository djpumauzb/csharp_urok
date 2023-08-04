// Zadayte znachenie M i N. Napishite programmu, 
// kotoraya vivedet vse naturalnie chisla v promejutke M do N.
// M = 1; N = 5 -> "1,2,3,4,5"
// M = 4; N = 8 -> "4,6,7,8"



void NaturalNumber(int M, int N)
{
    Console.Write($"M = {M}; N = {N} -> ");
    for (int i = M; i <= N; i++)
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

int M = GetInfo("Vvedite znachenie M: ");
int N = GetInfo("Vvedite znachenie N: ");

NaturalNumber(M, N);