// Napishite programmu, kotoraya vivodit sluchaynoe texznachnoe chislo
// i udalyaet vtoruyu  cifru etogo chisla

// 456 -> 46
// 782 -> 72
// 918 -> 98





//int num = new Random().Next(100, 1000);

int num = 798;
int dig1 = num / 100;  
int dig2 = num % 10;  

Console.WriteLine($"{dig1}{dig2}");
