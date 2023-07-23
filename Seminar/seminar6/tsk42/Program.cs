// Napishite programmu kotoraya budet pereobrazovivat'
// destichnoe chislo v dvoichnoie.

// 45 -> 101101
// 3 -> 11
// 2-> 10

void GetBinayrNum(int num)
{
    string temp = string.Empty;
    while (num > 0)
    {
        temp = (num % 2).ToString() + temp; // berete s konca poetomu + temp
        num = num / 2;
    }
    Console.Write(temp);
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Vvedite chislo: ");
GetBinayrNum(num);