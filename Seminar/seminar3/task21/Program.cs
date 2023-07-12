// Napishite programmu, kotoraya prinimaet na vxod koordinati
// dvux tochek i naxodit rasstoyanie mejdu nimi v 2D prostranstve

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Lenght(int xA, int yA, int xB, int yB) 
{
    double distance = Math.Sqrt(Math.Pow(xB - xA, 2)+ Math.Pow(yB - yA, 2));
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
int BxPoint = GetInfo("Vvedite kordinatu B(x): ");
int ByPoint = GetInfo("Vvedite kordinatu B(y): ");

double distance = Lenght(AxPoint, AyPoint, BxPoint, ByPoint);
string formattedDistance = distance.ToString("0.00");

Console.WriteLine($"A ({AxPoint}, {AyPoint}); B ({BxPoint}, {ByPoint}) -> {formattedDistance}");
