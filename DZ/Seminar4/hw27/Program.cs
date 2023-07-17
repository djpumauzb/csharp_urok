// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumm(int number)
{
    string numStr = number.ToString();
    int sum = 0;
    for (int i = 0; i < numStr.Length; i++)
    {
        sum = sum + int.Parse(numStr[i].ToString());
    }
    
    return sum;
}




int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Vvedite cislo: ");
Console.WriteLine($"{num} -> {GetSumm(num)}");