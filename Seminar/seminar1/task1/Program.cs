// Napishite programmu, kotoraya na vxod prinimaet dva chisla i
// proveryaet yavlaetsya li pervoe chislo kvadratom vtorogo
// a = 25, b = 5 -> da 
// a = 2, b = 10 -> net
// a = 9, b = -3 -> da
// a = -3, b = 9 -> net

Console.Write("Vvedite chislo: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Vvedite kvadrat etogo chisla: ");
int number2 = int.Parse(Console.ReadLine());
int kvadrat = number1 * number1;
if (number2 == kvadrat) {
    Console.WriteLine("da");
} else {
    Console.WriteLine("net");
}

