// Задача 41.
// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.

// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.Clear();

// ВАРИАНТ 1
Console.Write("Введите общее количество элементов: ");
int number = Convert.ToInt32(Console.ReadLine());
int quantityElements = QuantityElements(number);
Console.WriteLine($"Количество чисел > 0 = {quantityElements}");


int QuantityElements (int num)
{
    int count = 0;
    for( int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        int element = Convert.ToInt32(Console.ReadLine());

        if (element > 0) count++;
    }
    return count;
}


// ВАРИАНТ 2

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// PrintArray(array);
// int quantityPositivElementsArray = QuantityPositivElementsArray(array);
// Console.WriteLine($"В массиве количество чисел > 0 = {quantityPositivElementsArray}");

// int[] CreateArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите {i + 1} элемент массива: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.WriteLine($"index[{i}] = {arr[i]}");
//     }
// }

// int QuantityPositivElementsArray (int[] arr)
// {
//     int count = 0;
//     for( int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) count++;
//     }
//     return count;
// }