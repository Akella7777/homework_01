//Задача 50. 
//Напишите программу, 
//которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7->такого элемента в массиве нет

using System.ComponentModel.Design;

Console.Clear();


int matrixRows = InputRead("Введите количество строк матрицы: ");
int matrixColumns = InputRead("Введите количество столбцов матрицы: ");
int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, -100, 100);
PrintMatrix(array2D);
Console.WriteLine();
int row = InputRead("Введите индекс строки: ");
int column = InputRead("Введите индекс столбца: ");

if (row < 0 || column < 0) 
{
    Console.WriteLine($"Введены некорректные данные. Введите значение > 0");
}
else
{
    if (row >= array2D.GetLength(0) || column >= array2D.GetLength(1)) Console.WriteLine($"{row}, {column} -> Такого элемента нет");
    else Console.WriteLine($"Значение элемента с индексами {row}, {column} = {array2D[row, column]}");
}



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



// ВАРИАНТ 2
/*
Console.Clear();

int InputRead(string msg)
{
    Console.WriteLine(msg);
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

void FindElements(int[,] findElem, int userElement)
{
    bool found = false;
    for (int i = 0; i < findElem.GetLength(0); i++) //row
    {
        for (int j = 0; j < findElem.GetLength(1); j++) // columns
        {
            if (findElem[i, j] == userElement)
            {
                Console.WriteLine("Значение находится по индексу матрицы: " + i + ", " + j);
                found = true;
            }
        }
    }
    if (!found) Console.WriteLine("Такого значения в массиве нет");
}

int matrixRows = InputRead("Введите количество строк матрицы: ");
int matrixColumns = InputRead("Введите количество столбцов матрицы: ");
int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, -100, 100);
PrintMatrix(array2D);

int elementPosition = InputRead("Введите значение: ");
FindElements(array2D, elementPosition);
*/