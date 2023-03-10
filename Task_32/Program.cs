// Задача 32.
// Напишите программу замены элементов массива:
// положительные элементы замените на отрицательные, и наоборот.
// Найдите сумму положительных и отрицательных эдементов массива
//
// Пример.
// [-4,-8,8,2] -> [4,8,-8,-2] 


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

void InversArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * (-1);
    }
}

int[] array = CreateArrayRnd (4, -2, 9);
PrintArray(array);
InversArray(array);
PrintArray(array);
