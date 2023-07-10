//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Napishite 1oe chislo: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Napishite 2oe chislo: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 == num2) {
    Console.WriteLine("Vvedite razni chisla");
    Console.WriteLine("odni odinakovie )");     // dlya togo shtobi polzovatel ne vvel odinakovie znachenie )
}
int min = 0;
int max = 0;
if (num1 > num2) max = num1; min = num2;
if (num1 < num2) max = num2; min = num1;

if (num1 == max || num2 == max) {               // a eto chto bi ne srabativalo etot writeline sam po sebe, atolko togda kogda doydet do syuda) 
Console.WriteLine($"Max = {max}");
Console.WriteLine($"Min = {min}");
}
