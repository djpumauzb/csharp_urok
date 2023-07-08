// Napishite programmu, kotoraya ne vxod prinimaet celoe chislo i vidaet ego kvadrat (chislo umnojenie samogo sebya)

Console.Write("VVedite chislo dlya kvadrata: ");
int number = int.Parse(Console.ReadLine());
int kvadrat = number * number;
Console.WriteLine($"Kvadrat chisla {number} raven na: {kvadrat}");
