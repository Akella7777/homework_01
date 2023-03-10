//Задача 53:
//Задайте двумерный массив.
//Напишите программу, которая поменяет местами первую 
//и последнюю строку массива.

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

void Replace(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[firstRow, j];
        matrix[firstRow, j] = matrix[lastRow, j];
        matrix[lastRow, j] = temp;
    }
}


int matrixRows = InputRead("Введите количество строк матрицы: ");
int matrixColumns = InputRead("Введите количество столбцов матрицы: ");
int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
Replace(array2D);
PrintMatrix(array2D);