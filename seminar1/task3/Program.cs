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
}

//mojnmo i napisat if i else v odni strochku:

if (number == 1) Console.WriteLine("Dushanba");
if (number == 2) Console.WriteLine("Seshanba");
if (number == 3) Console.WriteLine("Chorshanba");
if (number == 4) Console.WriteLine("Payshanba");
if (number == 5) Console.WriteLine("Juma");
if (number == 6) Console.WriteLine("Shanba");
if (number == 7) Console.WriteLine("Yakshanba");
else Console.WriteLine("V nedeli sushastvuet tolko 7 dney.");

// Proverku na nevernochislo mojno srazu posle vvedenie chisla. 
// Eto umenshaet nagruzku i ne daet ustroystvo idti na nenaprasuyu usilie

// Tak shto sdelaem tak:
Console.Write("Vvedite chislo dnya nedeli: ");
int number = int.Parse(Console.ReadLine());
if (number > 7 || number < 1) Console.WriteLine("V nedeli sushastvuet tolko 7 dney."); 
if (number == 1) Console.WriteLine("Dushanba");
if (number == 2) Console.WriteLine("Seshanba");
if (number == 3) Console.WriteLine("Chorshanba");
if (number == 4) Console.WriteLine("Payshanba");
if (number == 5) Console.WriteLine("Juma");
if (number == 6) Console.WriteLine("Shanba");
if (number == 7) Console.WriteLine("Yakshanba");

// Nam nechego nenado napisat "else" tak kak nabrat mojno tolko chislo. 
// Potomu chto tam stoit "int" i eto kompensiruet "else"