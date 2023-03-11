//Задача 66: 
//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите первой число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int recursion = Recursion(number1, number2);
Console.Write($"{recursion} ");

int Recursion(int number1, int number2)
{
    if (number1 > number2)
    {
        if (number1 == number2) return (number1);
        return number1 + Recursion(number1 - 1, number2);
    }
    else
    {
        if (number1 == number2) return (number1);
        return number1 + Recursion(number1 + 1, number2);
    }
}
