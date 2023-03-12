//Задача 69:  Напишите программу,
//которая на вход принимает два числа А и В,
//и возводит число А в целую степень В
//с помощью рекурскии



Console.WriteLine("Введите основание: ");
int footing = int.Parse(Console.ReadLine());
int degree = KeybordInpurMoreInt("Введите в какую степень возводить число А: ", 0);
int exponentiation = Exponentiation(footing, degree);
Console.WriteLine(exponentiation);
if (degree < 0) Console.WriteLine("Ошибка ввода");
else Console.WriteLine($"{footing} в степени {degree} = {exponentiation}");

int Exponentiation (int num, int degree)
{
    if (degree ==  0) return 1;
    else return num * Exponentiation(num, degree - 1);
}

int KeybordInpurMoreInt (string msg, int more)
{
          Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    while (num < more)
    {
        Console.WriteLine("Введено не верное значение попробуйте еще раз! ");
        num = KeybordInpurMoreInt(msg, more);
    }
    return num;
}
