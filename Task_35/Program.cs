// Задача 35.
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива,
// значение которых лежат в диапазоне [10, 99]
//
// Пример.
// [5,18,123,6,2] -> 1 
// [1,2,3,6,2] -> 0 
// [10,11,12,13,14] -> 5 



int[] CreateArrayRnd (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountTwoSignArray (int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] <= 99) 
        count += 1;
    }
    return count;
}

int[] array = CreateArrayRnd (123, -1000, 1000);
PrintArray(array);
int existNum = CountTwoSignArray(array);
Console.WriteLine($"В массиве содержится {existNum} двузначных чисел");
