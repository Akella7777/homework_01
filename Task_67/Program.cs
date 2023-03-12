//Задача 67:
//Напишите программу, которая будет принимать на вход число
// и возвращить сумму его цифр.
//    453 -> 12
//    45 -> 9

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма цифр числа {number} = {sumDigit} ");

int SumDigit(int number)
{
    if (number == 0) return 0;
    else return number % 10 + SumDigit(number / 10);
}