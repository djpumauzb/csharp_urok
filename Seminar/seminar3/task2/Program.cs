// Napishite programmu, kotoraya po zadannomu nomeru chetverti pokazivaet 
// diapazon koordinat tochek i v etoy chetverti (x i y)


string CoordinateRange(int quarter)
{
    if (quarter == 1) return "x < 0, y > 0";
    if (quarter == 2) return "x < 0, y >";
    if (quarter == 3) return "x < 0, y < 0";
    if (quarter == 4) return "x > 0, y > 0";
    if (quarter < 1 || quarter > 4) {
        return "vvedite 1 do 4 !";
    }
    return "error";
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int range = GetInfo("Vvedite nomer chetverti: ");

Console.WriteLine($"{CoordinateRange(range)}");