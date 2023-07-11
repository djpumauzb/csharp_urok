// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N <= 0) {
    Console.WriteLine("Введите число больше 0!");
} else {
    Console.Write("Чётные числа: ");
    for (int i = 2; i <= N; i += 2) {
        Console.Write(i);
        if (i != N && i + 2 <= N) {         // а убрать "," в последном числе было не просто )
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}
