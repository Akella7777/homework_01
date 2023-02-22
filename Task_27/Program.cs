// Задача 27: 
// Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = NumberSimbol(number);
Console.WriteLine($"Введено число {number}. Сумма всех чисел = {digit}");

int NumberSimbol(int num)
{
    int result = 0;
    if (num == 0)
    {
        return 0;
    }
    else
    {
        while (num != 0)
        {
            result = result + num % 10;
            num = num / 10;
        }
        return result;
    }
}