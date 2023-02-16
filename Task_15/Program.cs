// 15. Напишите программу,
// которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Week(number))
{
    if (WeekEnds(number))
    {
        Console.WriteLine("Выходной!!!!!");
    }
    else 
    {
        Console.WriteLine("Всем работать, негры! Рабочий день!");
    }
}

bool Week (int day) 
{
    if (day > 0 && day <= 7)
    {
        return true;
    }
    Console.WriteLine("Введенное число не соответствует дню недели");
    Console.WriteLine("Число должно быть в диапазоне от 1 до 7");
    return false;
}

bool WeekEnds (int day) 
{
    if (day > 5)
    {
        return true;
    }
    return false;
}
