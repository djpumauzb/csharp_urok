// napishite programmu, kotoraya prinimaet na vxod koordinati tochki (X i Y), 
// prichem X != 0 i Y !=0 i vidaet nomer chetverti ploskosti, v kotoroy naxoditsya eta tochka

int DefQuarter(int xPoint, int yPoint)
{
    if (xPoint > 0 & yPoint > 0) return 1;
    if (xPoint < 0 & yPoint > 0) return 2;
    if (xPoint < 0 & yPoint < 0) return 3;
    if (xPoint > 0 & yPoint < 0) return 4;
    return 0;
}


int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}



int xPoint = GetInfo("Vvedite kordinatu X: ");
int yPoint = GetInfo("Vvedite kordinatu Y: ");
Console.WriteLine($"Eto {DefQuarter(xPoint, yPoint)} chetvert' !");
