// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Napishite 1oe chislo: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Napishite 2oe chislo: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Napishite 3oe chislo: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 == num2 & num2 == num3) {
    Console.WriteLine("oni vse odinakovie )");
}


int max = 0;

if (max < num1) max = num1;
if (num1 < num2) max = num2;
if (num2 < num3) max = num3;

if (num1 != num2 & num2 != num3) {
Console.WriteLine($"Max = {max}");
}
