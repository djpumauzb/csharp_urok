// Napishite programmu, kotoraya na vxod prinimaet odno chislo (N)
// a na vixode pokazivaet vse celie chisla v promejutke ot -N do N
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.Write("Vvedite chislo: ");
int N = int.Parse(Console.ReadLine());
int minusN = N * -1;
for (int i = minusN; i < N; i++) {
    Console.Write($"{i}, ");
}
Console.WriteLine(N);

// v programmirovanie ne obizatelno umnojat chislo na -1 shtobi poluchit minus
// prosto mojno napisat -N

Console.Write("Vvedite chislo: ");
int N = int.Parse(Console.ReadLine());
for (int i = -N; i < N; i++) {
    Console.Write($"{i}, ");
}
Console.WriteLine(N);