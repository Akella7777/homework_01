// Задача 2: Напишите программу, 
// которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// Пример:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
    Console.WriteLine($"число {numberA} больше числа {numberB}");
}
else if (numberA < numberB)
{
    Console.WriteLine($"max = {numberB}");
    Console.WriteLine($"число {numberA} меньше числа {numberB}");
}
else
{
    Console.WriteLine("числа равны");
    Console.WriteLine($"число {numberA} равно числу {numberB}");
}