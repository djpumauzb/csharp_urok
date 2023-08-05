// Napishite programmu, kotoraya budet prinimat' na vxod 
// chislo o vozvrashat' summu ego cifr
// 453 -> 12
// 45 - > 9

int SummNum(int num)
{
    if (num == 0) return 0;
    else
    {
        return num % 10 + SummNum(num / 10);
    }
}


int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Vvedite znachenie N: ");
int result = SummNum(num);
Console.WriteLine($"{num} -> {result}");