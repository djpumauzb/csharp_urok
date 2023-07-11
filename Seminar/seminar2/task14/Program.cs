// Napsihite programmu, kotoraya prinimaet na vxod chislo i proveryaet,
// kratno li ono odnovremenno 7 i 23

// 14 - > net
// 46 -> net
// 161 -> da

Console.Write("Vvedite chislo: ");
int num = int.Parse(Console.ReadLine());

int check1 = num % 7;
int check2 = num % 23;

if (check1 == 0 & check2 == 0) {
    Console.WriteLine("Da");
} else {
    Console.WriteLine("Net");
}