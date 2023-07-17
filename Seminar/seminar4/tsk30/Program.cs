// Napishite programmu, kotoraya vivodit massiv iz 8 elementov, 
// zapolnenniy nulyami i edinicami v sluchaynom poryadke
// [1,0,1,1,1,0]


int[] massiv = new int[8];
Random randomNum = new Random();
for (int i = 0; i < 8; i++)
{
    massiv[i] = randomNum.Next(0, 2);
}

string joinedArray = string.Join(",", massiv);
Console.WriteLine(joinedArray);


