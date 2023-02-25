// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Пример:
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// ВАРИАНТ 1
/* Console.Clear();

int size = InputRead("Введите количество элементов массива: ");
double[] array = CreateArrayRndDouble(size, 0, 10);
Console.WriteLine($"Сформированный массив из {size} элементов");
PrintArrayDouble(array);
double difference = Math.Round(DifferenceMaxMin(array), 1);
Console.WriteLine($"Разница между максимальным и минимальным  числом  = {difference}");

int InputRead(string msg)
{
    Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.AwayFromZero); //Math.Round(value, 1, MidpointRounding.AwayFromZero);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]"); 
}

double DifferenceMaxMin(double[] arr)
{
    double min = arr.Min();
    Console.WriteLine($"Минимальное число массива = {min}");
    double max = arr.Max();
    Console.WriteLine($"Максимальное число массива = {max}");
    double difference = max - min;
    return difference;
}
 */

// ВАРИАНТ 2
Console.Clear();

int size = InputRead("Введите количество элементов массива: ");
double[] array = CreateArrayRndDouble(size, 0, 10);
Console.WriteLine($"Сформированный массив из {size} элементов");
PrintArrayDouble(array);
double maxNumber = FindMaxNumber(array);
Console.WriteLine($"Максимальное число массива = {maxNumber}");
double minNumber = FindMinNumber(array);
Console.WriteLine($"Минимальное число массива = {minNumber}");
double difference = Math.Round(DifferenceMaxMin(maxNumber, minNumber), 1);
Console.WriteLine($"Разница между максимальным и минимальным числом массива = {difference}");

int InputRead(string msg)
{
    Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double FindMaxNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMinNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double DifferenceMaxMin(double max, double min)
{
    double difference = max - min;
    return difference;
}