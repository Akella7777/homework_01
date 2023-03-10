// 9. Напишите программу, которая 
// выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");

int digit = Digit(number);
Console.WriteLine($"Число равно = {digit}");

int Digit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int sum = firstDigit * 10 + secondDigit;
    return sum;
}