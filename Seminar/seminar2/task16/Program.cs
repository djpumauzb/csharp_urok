// Napishite programmu, kotoraya prinimaet na vxod 2 tipa chisla i proveryaet,
// yavlyaetsya li odno chislo kvadratom drugogo.

// 5, 25 -> da
// -4, 16 -> da
// 25, 5 -> da
// 8, 9 -> net

// poprobuyte funkcii

Console.Write("Vvedite 1oe chislo: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Vvedite 2oe chislo: ");
int num2 = int.Parse(Console.ReadLine());

// sqr1 = num1 * num1;
// sqr2 = num2 * num;
// vsmeto mojno tak s funsiey
int sqr(int arg)
{
    return arg*arg;
}

if (sqr(num1) == num2 || sqr(num2) == num1) {
    Console.WriteLine($"{num1}, {num2} -> da");
}
else 
{
    Console.WriteLine($"{num1}, {num2} -> net");
}