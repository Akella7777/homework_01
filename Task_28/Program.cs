//Задача 28: Напишите программу, 
// которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.Clear();

Console.WriteLine("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int factorial = Factorial(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");
}
else
{
    Console.WriteLine("Введено не натуральное число");
}

int Factorial(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        checked // проверяет на переполнение
        {
            sum = sum * i;
        }
    }
    return sum;
}
