// Задача 21
// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/* 
Console.WriteLine ("введите коордионату Х точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите коордионату Y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите коордионату Z точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите коордионату Х точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите коордионату Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите коордионату Z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
Console.WriteLine($"Длина отрезка AB равна {result}");
 */

// ВАРИАНТ 2
int x1 = Promt("Введите коордионату Х точки A: ");
int y1 = Promt("Введите коордионату Y точки A: ");
int z1 = Promt("Введите коордионату Z точки A: ");
int x2 = Promt("Введите коордионату Х точки B: ");
int y2 = Promt("Введите коордионату Y точки B: ");
int z2 = Promt("Введите коордионату Z точки B: ");

int a = (x2 - x1)*(x2 - x1);
int b = (y2 - y1)*(y2 - y1);
int c = (z2 - z1)*(z2 - z1);

Console.WriteLine($"Длина отрезка AB равна: " + SegmentLength(a, b, c));

int Promt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double SegmentLength (int A, int B, int C)
{
    double result = Math.Sqrt(A + B + C);
    return result;
}