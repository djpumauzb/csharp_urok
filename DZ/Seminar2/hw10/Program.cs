// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Vvedite chislo: ");
int num = int.Parse(Console.ReadLine());
if (num >= 999 || num <= 99) {
    Console.WriteLine("Vvedite tolko trexznachnoe chislo :(");
} else {
    int del = num / 10;
    int result = del % 10;
    Console.WriteLine($"{num} -> {result}");
}
