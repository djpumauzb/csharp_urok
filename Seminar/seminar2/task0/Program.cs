// Napishite funksiyu, kotoraya vivodit sluch chislo iz trezka [10, 99] 
// i pokazivaet naibolshuyu cifru chisla

// Exmp:
// 78 -> 8
// 12 -> 2
// 85 -> 8

// generirovat sluch chisl
// zapisat cifru po otdelnosti
// sravnit i vivesti naiboluyu

int num = new Random().Next(10, 100);
int dig1 = num / 10;  // vozmet 1oe chislo
int dig2 = num % 10;  // vozmet ostatok (2oe) chislo

int max = dig1;

if (max < dig2) 
{
     max = dig2;
}

Console.WriteLine($"Max cifra v chisle {num} -> {max}");