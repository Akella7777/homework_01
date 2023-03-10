//Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine($"Введите трехзначное число от 100 до 999: ");
int number = Convert.ToInt32(Console.ReadLine());


int digit = Digit(number);
Console.WriteLine($"Число равно = {digit}");

int Digit(int num)
{
    if (number < 100 || number > 999)
//    {
//        Console.WriteLine("Введено не трехзначное число. Введите число от 100 до 999");
//    }
//    else
    {
        return number / 10 % 10;
    }
}