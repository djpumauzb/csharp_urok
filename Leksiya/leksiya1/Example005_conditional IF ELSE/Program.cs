Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "masha")
{
    Console.WriteLine("Это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
