// Задача 42: 
// Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.

// Пример:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string transformtionNumber = TransformtionNumber(number);
Console.WriteLine($"Двоичный код = {transformtionNumber}");



string TransformtionNumber (int num)
{
    string newNum = string.Empty;
    while(num != 0)
    {
        newNum = num % 2 + newNum;
        num = num / 2;
    }
    return newNum;
}

