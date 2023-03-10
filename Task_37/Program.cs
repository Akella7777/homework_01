// Задача 37.
// Найдите произведение пар чисел в одномерном массиве.
// Парой считается первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новый массив.
//
// Пример.
// [1,2,3,4,5] -> 583 
// [6,7,3,6] -> 36 21  



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

int[] CompositionNumber(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (newArray.Length % 2 == 0)
    {
        newArray[newArray.Length - 1] = arr[size - 1];
    }
    return newArray;
}

int[] array = CreateArrayRnd(9, 0, 4);
int[] arrat2 = CompositionNumber(array);
PrintArray(array);
PrintArray(arrat2);
