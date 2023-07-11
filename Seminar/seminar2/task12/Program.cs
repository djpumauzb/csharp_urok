// Napishite programmu, kotoraya budet prinimat na vxod 2 chisla i vivodit, yavlyaetsya
// li 2oe chislo kratnim pervomu. Esli chislo 2 ne kratno chislu 1, to
// programma vivodit ostatok ot deleniya

// 34, 5 -> ne kratno, ostatok 4
// 16, 4 -> kratno

Console.Write("Vvedite 1oe chislo: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Vvedite 2oe chislo: ");
int num2 = int.Parse(Console.ReadLine());

int ostatok = num1 % num2; // ludshe s peremnnoi rabotat )

if (ostatok == 0) {
    Console.WriteLine("Kratno");
}
if (ostatok != 0) {
    Console.WriteLine($"Ne kratno, ostatok {ostatok}");
}