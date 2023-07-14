// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Lenght(int xA, int yA, int xZ, int xB, int yB, int yZ) 
{
    double distance = Math.Sqrt(Math.Pow(xB - xA, 2)+ Math.Pow(yB - yA, 2)+ Math.Pow(xZ - yZ, 2));
    return distance;
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int AxPoint = GetInfo("Vvedite kordinatu A(x): ");
int AyPoint = GetInfo("Vvedite kordinatu A(y): ");
int AzPoint = GetInfo("Vvedite kordinatu A(y): ");
int BxPoint = GetInfo("Vvedite kordinatu B(x): ");
int ByPoint = GetInfo("Vvedite kordinatu B(y): ");
int BzPoint = GetInfo("Vvedite kordinatu A(y): ");

double distance = Lenght(AxPoint, AyPoint, AzPoint, BxPoint, ByPoint, BzPoint);
string formattedDistance = distance.ToString("0.00");

Console.WriteLine($"A ({AxPoint}, {AyPoint}, {AzPoint}); B ({BxPoint}, {ByPoint}, {BzPoint}) -> {formattedDistance}");