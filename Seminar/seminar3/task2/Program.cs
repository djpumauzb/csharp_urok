// Napishite programmu, kotoraya po zadannomu nomeru chetverti pokazivaet 
// diapazon koordinat tochek i v etoy chetverti (x i y)


string CoordinateRange(int quarter)
{
    string xRange = "";
    string yRange = "";
    if (quarter == 1)
    {
        xRange = "x < 0";
        yRange = "y > 0";
    }
    if (quarter == 2)
    {
        xRange = "x < 0";
        yRange = "y > 0";
    }
    if (quarter == 3)
    {
        xRange = "x < 0";
        yRange = "y < 0";
    }
    if (quarter == 4)
    {
        xRange = "x > 0";
        yRange = "y > 0";
    }
    if (quarter < 1 || quarter > 4) {
        return "vvedite 1 do 4 !";
    }
    return xRange + " and " + yRange;
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int range = GetInfo("Vvedite nomer chetverti: ");

Console.WriteLine($"{CoordinateRange(range)}");