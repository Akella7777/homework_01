// Задача 43.
// Напишите программу,
// которая найдет точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения k1, b1, k2, b2 задаются пользователем.

// Пример:
// k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0.5; -0.5)

// k1 * x + b1  = k2 * x + b2;
// k1 * x - k2 * x  = b2 - b1;
// x = b2 - b1 / (k1 - k2);
// x = -(b1 - b2) / (k1 - k2);

double k1 = InputRead ("Введите значение k1: ");
double b1 = InputRead ("Введите значение b1: ");
double k2 = InputRead ("Введите значение k2: ");
double b2 = InputRead ("Введите значение b2: ");

if(k1 == k2 && b1 == b2) Console.WriteLine("Прямые проходят по идентичным точкам. Прямые совпадают.");
else if(k1 == k2) Console.WriteLine("Прямые не имеют пересечений - прямые параллельны друг другу.");
else
{
    double result1 = Math.Round(PointIntersection(k1, b1),1);
    double result2 = Math.Round(PointIntersection(k2, b2),1);
    Console.WriteLine($"Пересечение прямых в точке: ({result1}; {result2})");
}

double PointIntersection (double numA, double numB)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = numA * x + numB;  
    return Math.Round(y,1);
}

double InputRead(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}