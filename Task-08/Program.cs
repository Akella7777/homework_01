// Задача 8: Напишите программу
// которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int index = 1;

if (numberN < 1)
{
    Console.WriteLine("Введено некорректное число. Введите натуральное число");
}

if (numberN == 1)
{
    Console.WriteLine("Введено число 1. Ряд из натуральных чисел отсутствет");
}

while (index <= numberN)
{
    if (index % 2 == 0)
    {
        Console.Write(index + " ");
    }
    index++;
}