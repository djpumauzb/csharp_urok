// Napishite programmu, kotoraya prinimaet 
// na vxod chislo i vidaet kolichestvo cifr v chisle
// 456 -> 3
// 78 -> 2
// 89123 -> 5

int NumLenght(int number) 
{
    string numStr = number.ToString();
    int lenght = numStr.Length;
    return lenght; 
}


int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Vvedite cislo: ");

Console.WriteLine($"{num} -> {NumLenght(num)}");