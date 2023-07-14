// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string IsPalindrome(int num)
{
    if (num >= 99999 || num < 10000) return "Введите только пятизначное число !";
    string strnum = num.ToString();
    int lenght = strnum.Length;
    string input = $"{num} -> ";
    for (int i = 0; i < lenght / 2; i++)
    {
        if (strnum[i] != strnum[lenght - i - 1]) return input + "no";
    }
    return input + "yes";
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Vvedite chislo: ");
Console.WriteLine(IsPalindrome(num));