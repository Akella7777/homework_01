//16. Напишите программу, 
// которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(Square(firstNumber, secondNumber)) Console.WriteLine("Yes");
else Console.WriteLine("No"); 

bool Square(int numA, int numB)
{
    return numB == numA * numA || numA == numB * numB;
}
