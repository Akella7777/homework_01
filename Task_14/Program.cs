//14. Напишите программу, 
// которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да


Console.WriteLine("Введите число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if (MultiplycityTwoNumbers(firstNumber)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

bool MultiplycityTwoNumbers (int num)
{
    return num % 7 == 0 && num % 23 == 0;
}