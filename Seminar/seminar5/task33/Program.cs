// Zadayte massiv. Napishite programmu, kotoraya opredelyaet,
// prisustvuet li zadannie chislo v massive.
// 4; massiv [6, 7, 19, 345, 3] -> net
// -3; massiv [6, 7, 19, 345, 3] -> da

bool CheckNumArray(int[] array, int number) // proverit number v massive i vernet true ili false
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number || array[i] == -number) return true;
    }
    return false;
}

int[] NewRandomArray(int size, int minValue, int maxValue) // Pechataet randomnie massivi s opredelonnimi diapazonami
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().Next(minValue, maxValue);
    return massiv;
}

int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int[] array = NewRandomArray(5, -9, 9);
int num = GetInfo("Vvedite cislo: ");

Console.Write($"{num} -> [{string.Join(",", array)}] -> ");
if (CheckNumArray(array, num))
    Console.Write("Yes");
else
    Console.Write("No");



// Better way with sting
string CheckNumArray1(int[] array, int number) // proverit number v massive i vernet tekst
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number || array[i] == -number) return "Yes";
    }
    return "No";
}

int[] NewRandomArray1(int size, int minValue, int maxValue) // Pechataet randomnie massivi s opredelonnimi diapazonami
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().Next(minValue, maxValue);
    return massiv;
}

int[] array1 = NewRandomArray1(5, -9, 9);
int num1 = GetInfo("Vvedite cislo: ");

Console.Write($"{num1} -> [{string.Join(",", array1)}] -> {CheckNumArray(array1, num1)} ");