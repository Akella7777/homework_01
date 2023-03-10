// Задача 40: 
// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

bool Sidelength(int numA, int numB, int numC)
{
    if (numA < numB + numC && numC < numB + numA && numB < numC + numA) return true;
    else return false;
}

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (Sidelength(numberA, numberB, numberC))
{
    Console.WriteLine("Треугольник существует!!!!!");
}
else
{
    Console.WriteLine("Треугольник Не существует");
}



// Console.Clear();

// int a = NumberInput("Введите сторону a: ");
// int b = NumberInput("Введите сторону b: ");
// int c = NumberInput("Введите сторону c: ");

// bool result = true;

// Comparison(a, b, c);
// Comparison(b, a, c);
// Comparison(c, a, b);

// if (result) Console.WriteLine("Треугольник существует");
// else Console.WriteLine("Треугольник не существует");


// void Comparison(int x1, int x2, int x3)
// {
//     if (x1>x2+x3) result = false;
// }

// int NumberInput(string msg)

// {
//     System.Console.Write(msg);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }







// bool InequalityTriangle(int a1, int b1, int c1)
// {
//     if (a1 >= b1 + c1 || b1 >= a1 + c1 || c1 >= a1 + b1) return true;
//     else return false;
// }