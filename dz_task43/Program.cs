// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double MetodX(double b1, double k1, double b2, double k2)
{
    double pointX = (b2 - b1) / (k1 - k2);
    return pointX;
}

double MetodY(double b1, double k1, double b2, double k2, double numX)
{
    double pointY = k2 * numX + b2;
    return pointY;
}

Console.WriteLine("Введите число b1: ");
double numB1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k1: ");
double numK1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b2: ");
double numB2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k2: ");
double numK2 = Convert.ToInt32(Console.ReadLine());

double numX = MetodX(numB1, numK1, numB2, numK2);
double numY = MetodY(numB1, numK1, numB2, numK2, numX);

if (numK1 == numK2)
    {
        Console.WriteLine($"Прямые не пересекаются");      //проверки параллельны прямые или совпадают не требует задача
    }
else 
Console.WriteLine($"Точки пересечения двух прямых -> ({Math.Round(numX, 2)}; {Math.Round(numY, 2)})");
