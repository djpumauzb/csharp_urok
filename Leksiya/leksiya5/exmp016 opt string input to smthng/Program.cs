// string text = "(1,2) (2,3) (4,5) (6,7)";

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                                .Replace("(", "")
                                .Replace(")", "")
                                ;

Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(","))
                .Select(cordinate => (int.Parse(cordinate[0], int.Parse(cordinate[1]))))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    // Console.WriteLine(data[i]);
    for (int j = 0; j < data[i].Length; j++)
    {
        Console.WriteLine(data[i][j]);
    }
    Console.WriteLine();
}
