// Задача 44: 
// Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// Пример:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// if (number == 0) Console.WriteLine("Массив не может быть пустым");
int[] array = FibonacciArray(number);
PrintArray(array);

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] FibonacciArray(int num)
{
    int[] fibArr = new int[num];
    fibArr[0] = 0;

    if (num > 1)
    fibArr[1] = 1;
    {
        for (int i = 2; i < num; i++)
        {
            fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
        }
    }
    return fibArr;
}





