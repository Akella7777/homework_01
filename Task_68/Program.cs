//Задача 68: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

using System;

Console.WriteLine("Введите первой число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int recursion = Recursion(number1, number2);
Console.Write($"{recursion} ");

int Recursion(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0 && m > 0)  return Recursion(m - 1, 1);
        else return Recursion(m - 1, Recursion(m, n - 1));
    }