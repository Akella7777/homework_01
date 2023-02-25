// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Пример:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int size = InputRead("Введите количество элементов массива: ");
int[] array = CreateArrayRnd(size, 0, 10);
Console.WriteLine($"Сформированный массив из {size} элементов");
PrintArray(array);

if (size == 0)
{
    Console.WriteLine("Массив пустой. Числа в массиве отсутствуют");
}
else if (size == 1)
{
    Console.WriteLine("Нечетные числа в массиве отсутствуют");
}
else
{
    int sumElementsOddPosition = SumElementsOddPosition(array);
    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {sumElementsOddPosition}");
}

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

int SumElementsOddPosition(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}


