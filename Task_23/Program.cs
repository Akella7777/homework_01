// Задача 23
// Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// ВАРИАНТ 1
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
  Console.WriteLine($"Число {i} в третьей степени = " + ThirdDegree(i));
}

int ThirdDegree (int num)
{
  return num * num * num;
}