//Задача 49:
//Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса четные, 
//и замените эти элементы на их квадраты.

using System.Globalization;

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

void PrintMatrixy(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

void SquareOnIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

//int[,] matrix = new int[rows, columns];
//    for (int i = 0; i < matrix.GetLength(0); i + 2)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j + 2)
//        {
//             matrix[i, j] *= matrix[i, j];
//        }

int[,] aaray2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrixy(aaray2d);
Console.WriteLine();
SquareOnIndex(aaray2d);
PrintMatrixy(aaray2d);

