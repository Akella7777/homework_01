// Задача 25.
// Напишите цикл, 
// который принимает на вход два числа (А и В)
// и возводит число А в натуральную степеь В

// 3, 5 -> 243(3^5)
// 2, 4 -> 16 (2^4)

Console.Clear();

int basis = InputRead("Введите число: ");
int exponent = InputRead("Введите степень: ");

if (Validate(exponent))
{
    Console.WriteLine($"Число {basis} в степени {exponent} = {NumberInExponent (basis, exponent)}");
}

int InputRead(string msg)
{
    Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool Validate(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Введено отрицательное число. Степень числа должна быть положительной");
        return false;
    }
    else if (exponent == 0)
    {
        Console.WriteLine("Любое число в степени 0, всегда равно 1");
        return false;
    }
    return true;
}

int NumberInExponent (int basis, int exponent)
{
    int result = 1;
    for(int i = 0; i < exponent; i++)
    {
        checked
        {
            result = result * basis;
        }
    }
    return result;
}
