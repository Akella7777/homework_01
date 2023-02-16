//Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число от 100 до 999: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int secondDigitNumber = Number(number);
    Console.WriteLine($"Вторая цифра введеного числа = {secondDigitNumber}");
}
else
{
    Console.WriteLine($"Введенное число {number} не является трехзначным. Введите число от 100 до 999");
}

int Number(int num)
{
    return num / 10 % 10;
}