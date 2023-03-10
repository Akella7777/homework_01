// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Пример:
// [345, 897, 568, 234] -> 2

// ВАРИАНТ 1
Console.Clear();

int size = InputRead("Введите количество элементов массива: ");

int[] array = CreateArrayRnd(size, 100, 1000);
Console.WriteLine($"Сформированный массив из {size} элементов");
PrintArray(array);
int quantityEvenNumbers = CountQuantityEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {quantityEvenNumbers}");

int InputRead(string msg)
{
    Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountQuantityEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
}

// ВАРИАНТ 2
/* Console.Clear();

int[] array = CreateArrayRnd(10, 100, 1000);
Console.WriteLine($"Сформированный массив из {size} элементов");
PrintArray(array);
int quantityEvenNumbers = CountQuantityEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {quantityEvenNumbers}");

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountQuantityEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
} */