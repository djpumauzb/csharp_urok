// Napishite programmu, kotoraya prinimaet na vxod tri
// chisla i proveryaet, mojet li sushestvovat' 
// treugolnik s storonami takoy dlini
// Teorema o neravenstve trugolnika: kajdaya storona 
// treugolnika menshe summi dvux drugix storon


void CheckTriangle(int a, int b, int c)
{
    if (a + b > c & b + c > a & c + a > b)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}



int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int a = GetInfo("Vvedite a: ");
int b = GetInfo("Vvedite b: ");
int c = GetInfo("Vvedite c: ");

CheckTriangle(a, b, c);