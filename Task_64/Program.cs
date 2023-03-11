//Задача 64: 
//Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//ВАРИАНТ 1

Console.Write("Введите натуральное число:  ");
string res = Console.ReadLine();
if (int.TryParse(res, out int result))
{
    NaturalNumbers(result);

    void NaturalNumbers(int number)
    {
        if (number == 0) return;
        Console.Write($"{number}, ");
        NaturalNumbers(number - 1);
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Не удалось распознать число. Введите число!");
    Console.ResetColor();
}


// ВАРИАНТ 2

//while (true)
//{
//    Console.Write("Введите натуральное число:  ");
//    string text = Console.ReadLine();
//    if (int.TryParse(text, out int number))
//    {
//        NaturalNumbers(number);

//        void NaturalNumbers(int number)
//        {
//            if (number == 0) return;
//            Console.Write($"{number}, ");
//            NaturalNumbers(number - 1);
//        }
//        break;
//    }
//    else Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
//}
