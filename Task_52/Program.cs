//Задача 52. 
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

Console.Clear();

int InputRead(string msg)
{
    Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreateMatrixRndDouble(int row, int columns, int min, int max)
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

void PrintArrayDouble(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
}

double[] AveregeColumns(int[,] matrix)
{
    double[] averageColumn = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averageColumn[j] += Convert.ToDouble(matrix[i, j]);
        }
    }
    for (int i = 0; i < averageColumn.Length; i++)
    {
        averageColumn[i] /= matrix.GetLength(0);
        averageColumn[i] = Math.Round(averageColumn[i], 1);
    }
    return averageColumn;
}

int matrixRows = InputRead("Введите количество строк: ");
int matrixColumns = InputRead("Введите количество столбцов: ");
int[,] array2D = CreateMatrixRndDouble(matrixRows, matrixColumns, 0, 10);
PrintMatrix(array2D);
double[] averegeColumns = AveregeColumns(array2D);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(averegeColumns);


// ВАРИАН 2 (отличается только выводом в консоль)

//int InputRead(string msg)
//{
//    Console.WriteLine(msg);
//    int result = Convert.ToInt32(Console.ReadLine());
//    return result;
//}

//int[,] CreateMatrixRndDouble(int row, int columns, int min, int max)
//{
//    int[,] matrix = new int[row, columns];
//    Random rnd = new Random();
//    for (int i = 0; i < matrix.GetLength(0); i++) //row
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++) // columns
//        {
//            matrix[i, j] = rnd.Next(min, max + 1);
//        }
//    }
//    return matrix;
//}

//void PrintMatrix(int[,] matrix)
//{
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        Console.Write("|");
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            if (i < matrix.GetLength(1)) Console.Write($"{matrix[i, j],5} ");
//            else Console.Write($"{matrix[i, j],5}");
//        }
//        Console.WriteLine("|");
//    }
//}

//void PrintArrayDouble(double[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.Write($"Среднее арифметическое {i + 1} столбца: ");
//        if (i < arr.Length - 1) Console.WriteLine($"{arr[i]};");
//        else Console.Write($"{arr[i]}");
//    }
//}

//double[] AveregeColumns(int[,] matrix)
//{
//    double[] averageColumn = new double[matrix.GetLength(1)];
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            averageColumn[j] += Convert.ToDouble(matrix[i, j]);
//        }
//    }
//    for (int i = 0; i < averageColumn.Length; i++)
//    {
//        averageColumn[i] /= matrix.GetLength(0);
//        averageColumn[i] = Math.Round(averageColumn[i], 1);
//    }
//    return averageColumn;
//}

//int matrixRows = InputRead("Введите количество строк: ");
//int matrixColumns = InputRead("Введите количество столбцов: ");
//int[,] array2D = CreateMatrixRndDouble(matrixRows, matrixColumns, 0, 100);
//PrintMatrix(array2D);
//double[] averegeColumns = AveregeColumns(array2D);
//PrintArrayDouble(averegeColumns);
