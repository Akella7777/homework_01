//Задача 57:
//Составить частотный словарь элементов двумерного массива.
//Частотный словарь содержит информацию о том,
//сколько раз встречается элемент входных данных.

int InputRead(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreateMatrixRndInt(int row, int columns, int min, int max)
{
    int[,] matrix = new int[row, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(1)) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] MatrixToArray(int[,] matrix)
{
    int count = 0;
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count += 1;
        }
    }
    return array;
}

void SumElementsArray(int[] array)
{
    int count = 1;
    int currentNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNumber) count++;
        else
        {
            Console.WriteLine($"Число {currentNumber} встречается {count} раз");
            currentNumber = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {currentNumber} встречается {count} раз");
}

int matrixRows = InputRead("Введите количество строк матрицы: ");
int matrixColumns = InputRead("Введите количество столбцов матрицы: ");
int[,] matrix = CreateMatrixRndInt(matrixRows, matrixColumns, 0, 5);
int[] arr = MatrixToArray(matrix);
PrintMatrix(matrix);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Array.Sort(arr);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
SumElementsArray(arr);