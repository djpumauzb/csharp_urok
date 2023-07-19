// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

string GetOddSum(double[] array)
{
    double maxArr = array[0];
    double minArr = array[0];
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxArr)
        {
            maxArr = array[i];
        }
        if (array[i] < minArr)
        {
            minArr = array[i];
        }
    }
    difference = maxArr - minArr;
    string convertDiff = difference.ToString("0.##").Replace(',', '.');
    string convertmaxArr = maxArr.ToString("0.##").Replace(',', '.');
    string convertminArr = minArr.ToString("0.##").Replace(',', '.');
    return $"{convertmaxArr} - {convertminArr} = {convertDiff}";
}

double[] NewRandomArray(int size, double minValue, double maxValue)
{
    double[] massiv = new double[size];
    for (int i = 0; i < size; i++)
        massiv[i] = new Random().NextDouble() * (maxValue - minValue) + minValue; // NextDouble() ne prinimaet 2 zchnachenie prishlos ispolzovat' GPT :(
    return massiv;
}

double[] array = NewRandomArray(5, 1, 100);
string[] formatedArray = Array.ConvertAll(array, x => x.ToString("0.##").Replace(',', '.'));
string result = GetOddSum(array);
Console.Write($"[{string.Join(", ", formatedArray)}] -> {result}");