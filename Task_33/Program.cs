// Задача 33.
// Задайте массив.
// Напишите программу, которая определяет присутствует ли заданное число в массиве
//
// Пример.
// 4; массив [6,7,19,345,3] -> нет 
// 3; массив [6,7,19,345,3] -> да


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

bool FindElemArray (int[] arr, int num)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) return true;
    }
    return false;
}

int[] array = CreateArrayRnd (20, -20, 20);
PrintArray(array);
Console.WriteLine("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool existNum = FindElemArray(array, number);
Console.WriteLine(existNum ? "такое число есть" : "такого числа нет");