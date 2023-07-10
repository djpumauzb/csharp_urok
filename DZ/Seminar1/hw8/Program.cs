// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Vvedite chislo: ");
int N = int.Parse(Console.ReadLine());
int i = 0;
if (N == 0 || N < 0) Console.WriteLine("Vvedite chislo bolshe 0 !!!");

while (i < N & N != 0) {
    if (i % 2 == 0 & i != 0) {
        Console.Write($"{i}, ");
    }
    i++;
}

if (N != 0 || N > 0) {
    if (N % 2 == 0) {
    Console.WriteLine(N);
    }
}
