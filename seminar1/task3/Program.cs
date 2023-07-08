// Napishite programmu, kotoraya budet vidavat nazivanie dnya nedeli po zadannomu nomeru
// 3 -> Sreda
// 5-> Pyatnica


Console.Write("Vvedite chislo dnya nedeli: ");
int number = int.Parse(Console.ReadLine());
if (number == 1) {
    Console.WriteLine("Dushanba");
} else if (number == 2) {
    Console.WriteLine("Seshanba");
} else if (number == 3) {
    Console.WriteLine("Chorshanba");
} else if (number == 4) {
    Console.WriteLine("Payshanba");
} else if (number == 5) {
    Console.WriteLine("Juma");
} else if (number == 6) {
    Console.WriteLine("Shanba");
} else if (number == 7) {
    Console.WriteLine("Yakshanba");
} else {
    Console.WriteLine("V nedeli sushastvuet tolko 7 dney.");
    Console.WriteLine("Vvedite znachenie 1 do 7");
}