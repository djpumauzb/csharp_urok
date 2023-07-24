// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// // значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


(double,double) Equation(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}


int GetInfo(string msg)
{
    Console.Write(msg);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

double b1 = GetInfo("Vvedite b1: ");
double b2 = GetInfo("Vvedite b2: ");
double k1 = GetInfo("Vvedite k1: ");
double k2 = GetInfo("Vvedite k2: ");
(double, double) result = Equation(b1, b2, k1, k2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {result}");
