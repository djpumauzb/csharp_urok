// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num < 1 || num > 7) {
    Console.WriteLine("Vvedite chislo 1 do 7");
} else {
    int monday = 1;
    int tuesday = 2;
    int wednesday = 3;
    int thursday = 4;
    int friday = 5;
    int saturday = 6;
    int sunday = 7;
    if (num == saturday || num == sunday) {
        Console.WriteLine($"{num} -> yes");
    } else {
        Console.WriteLine($"{num} ->no");
    }

}


