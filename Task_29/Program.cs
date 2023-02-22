// Задача 30: Напишите программу, которая
// задаёт массив из 8 элементов, 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

Console.WriteLine("Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Начальное значение диапазона массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Конечное значение диапазона массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = NewRandomArray(number, min, max);
Console.Write($"Получен массив из {number} элементов -> ");
PrintArray(arr);

int[] NewRandomArray(int num, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]},");
    Console.Write("]");
}
