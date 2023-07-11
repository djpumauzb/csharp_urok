// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Vvedite chislo: ");
// double num = double.Parse(Console.ReadLine());

// if (num < 100) {
//     Console.WriteLine($"{num} -> третьей цифры нет");
// } else {
//     double result = (num / 100) % 10;
//     Console.WriteLine($"{num} -> {result}");
// }



Console.Write("Введите число: ");
string num = Console.ReadLine();

if (num.Length < 3) {
    Console.WriteLine($"{num} -> третьей цифры нет");
} else {
    char result = num[2];
    Console.WriteLine($"{num} -> {result}");
}
