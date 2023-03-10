/* 
int[] array = new int[8]; // { 0, 1, 2, 3, 4, 5, 6, 7}; для заполенения числами в таком порядке
array[0] = 23; //первому элементу присваиваем 23
Random.Next(0, 2); // рандом от 0 до 1
 */

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

Console.WriteLine("Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = NewRandomArray(number, 0, 1);
Console.WriteLine($"Полученный массив из {number} элементов");
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
