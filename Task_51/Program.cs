//Задача 51: 
//Задайте двумерный массив.
// Найдите сумму
// элементов, находящихся на главной диагонали 
//(с индексами
// (0,0); (1;1) и т.д.


// Например, задан массив
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12


using System;

Console.Clear();

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
            if (i < matrix.GetLength(1)) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

int DiadonalIndexSum(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++) //row
    {
        result += matrix[i, i];
    }
    return result;
}

int[,] aaray2d = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrixy(aaray2d);
Console.WriteLine();
int res = DiadonalIndexSum(aaray2d);
Console.WriteLine($"Сумма элементов главной диагонали {res}");