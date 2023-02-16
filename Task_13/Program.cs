// 13. Напишите программу,
// которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// ВАРИАНТ 1

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (ValidateNumber(number))
{
    Console.WriteLine(Number(number));
}

bool ValidateNumber(int num)
{
    if (number < 100)
    {
        Console.WriteLine("Двузначное число. Третьей цифры нет");
        return false;
    }
    return true;
}

int Number(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

// ВАРИАНТ 2

// if (number < 100)
// {
//     Console.WriteLine($"Третьей цифры нет");
// }
// else
// {
//     int thirdDigit = Number(number);
//     Console.WriteLine($"Третья цифра введеного числа = {thirdDigit}");
// }

// int Number(int num)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     return num % 10;
// }
