//Задача 65: Задайте значения M и N. Напишите программу, которая
//выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5-> "1, 2, 3, 4, 5"
//M = 4; N = 8-> "4, 5, 6, 7, 8"

Console.WriteLine("Введите первой число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
PrintNumber(number1, number2);

void PrintNumber(int number1, int number2)
{
    if (number1 > number2)
    {
        Console.Write($"{number1} ");
        PrintNumber(number1 - 1, number2);
    }
    else if (number1 < number2)
    {
        PrintNumber(number1, number2 - 1);
        Console.Write($"{number2} ");
    }
    else 
    {
        Console.Write($"{number2} ");
    }
}