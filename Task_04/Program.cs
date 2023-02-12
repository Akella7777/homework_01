// Задача 4: Напишите программу, 
// которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// Пример:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22 

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int numberMax = numberA;

if (numberMax > numberB)
{
    if (numberMax > numberC)
    {
        Console.WriteLine($"Наибольшее число = {numberMax}");
    }
    else
    {
        numberMax = numberC;
        Console.WriteLine($"Наибольшее число = {numberMax}");
    }
}
else
{
    numberMax = numberB;
    if (numberMax > numberC)
    {
        Console.WriteLine($"Наибольшее число = {numberMax}");
    }
    else
    {
        numberMax = numberC;
        Console.WriteLine($"Наибольшее число = {numberC}");
    }
}


