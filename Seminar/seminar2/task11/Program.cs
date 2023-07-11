// Napishite programmu, kotoraya vivodit sluchaynoe texznachnoe chislo
// i udalyaet vtoruyu  cifru etogo chisla

// 456 -> 46
// 782 -> 72
// 918 -> 98





int num = new Random().Next(100, 1000);

int dig1 = num / 100;  
int dig2 = num % 10;

// mojno i tak:
// num / 100 * 10; - pervoe chislo s odavlenoim 0 pri umnojenii nebudet konfliktov
// num % 100 % 10; - poslednee chislo no netuu smisla mojno i srazu num % 10
// i posle dig1 + dig2 = esli 956 to budet 90 + 6 = 96

Console.WriteLine($"V chisle: {num} -> {dig1}{dig2}");