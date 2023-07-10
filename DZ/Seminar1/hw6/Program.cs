// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Vvedite chislo: ");
int num = int.Parse(Console.ReadLine());
if (num == 0) Console.WriteLine("0 ne yavlaetsya chetnim ili nechetnim :)");
if (num % 2 == 0 & num != 0) Console.WriteLine("Yes");
if (num % 2 != 0 & num != 0) Console.WriteLine("No");
