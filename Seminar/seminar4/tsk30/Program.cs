// Napishite programmu, kotoraya vivodit massiv iz 8 elementov, 
// zapolnenniy nulyami i edinicami v sluchaynom poryadke
// [1,0,1,1,1,0]

int[] MekeNewBinaryArray(int size)
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++) 
        massiv[i] = new Random().Next(2);
    return massiv;
}

int[] massiv = MekeNewBinaryArray(8);
Console.WriteLine(string.Join(",", massiv));


