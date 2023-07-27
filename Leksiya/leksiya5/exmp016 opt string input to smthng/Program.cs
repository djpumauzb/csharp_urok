// string text = "(1,2) (2,3) (4,5) (6,7)";

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                                .Replace("(", "")
                                .Replace(")", "")
                                ;

Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(","))
                .Select(cordinate => (x: int.Parse(cordinate[0]), y: int.Parse(cordinate[1])))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i].x*10);
    Console.WriteLine();
}
