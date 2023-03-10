//12. Напишите программу, 
//которая будет принимать на вход два числа 
// и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, топрограмма выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int digit = Number(firstNumber, secondNumber);

if (digit == 0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно, остаток : " + digit);

int Number(int numA, int numB)
{
    return numA % numB;
}