// Napishite programmi, kotoraya prinimaet 
// na vxod trexznachnoe chislo i na vixode pokazivaet poslednuyu cifru etogo chisla
// 456 -> 6
// 782 -> 2


Console.Write("Vvedite trexnachnoe chilo: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Poslednaya chislo {number} eto {number % 10}");