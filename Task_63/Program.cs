//Задача 63: Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());
NaturalNumbers(number);

void NaturalNumbers(int number)
{
    if (number == 0) return;
    NaturalNumbers(number - 1);
    Console.Write($"{number} ");
}