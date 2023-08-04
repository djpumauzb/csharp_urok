// Zadayte znachenie M i N. Napishite programmu, 
// kotoraya vivedet vse naturalnie chisla v promejutke M do N.
// M = 1; N = 5 -> "1,2,3,4,5"
// M = 4; N = 8 -> "4,6,7,8"



// void NaturalNumber(int M, int N)
// {
//     if (M > N) {
//         Console.WriteLine("Vvedite M do N!: M < N)");
//         return;
//     }
//     Console.Write($"M = {M}; N = {N} -> ");
//     for (int i = M; i <= N; i++)
//     {
//         Console.Write($"{i}");
//         if (i < N)
//         {
//             Console.Write(",");
//         }
//     }
// }

string NaturalNumber(int M, int N) // thi is recursion :|
{
    if (M < N)
    {
        return $"{M}, {NaturalNumber(M + 1, N)}";
    }
    else return Convert.ToString(N);
}


int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int M = GetInfo("Vvedite znachenie M: ");
int N = GetInfo("Vvedite znachenie N: ");

string result = NaturalNumber(M, N);
Console.WriteLine($"M = {M}; N = {N} -> {result} ");