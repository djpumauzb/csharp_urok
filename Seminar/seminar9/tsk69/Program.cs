// Napishite programmu, kotoraya na vxod prinimaet dva chisla A i B, 
// i vozvodit chislo a v celuyu stepen' B s pomochyu rekursii
// A = 3; B = 5 -> 243(3^5)
// A = 2; B = 3 -> 8

int PowNum(int A, int B)
{
    if (B > 0)
    {
        return A * PowNum(A, B - 1);
    }
    else return 1;
}


int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int A = GetInfo("Vvedite znachenie A: ");
int B = GetInfo("Vvedite znachenie B: ");
int result = PowNum(A, B);
Console.WriteLine($"A = {A}; B = {B} -> {result}");