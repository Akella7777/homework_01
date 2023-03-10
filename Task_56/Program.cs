// Задача 56:
// Задайте прямоугольный двумерный массив.
// Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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
            if (i < matrix.GetLength(1)) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int CountMinSumRow(int[,] matrix)
{
    int minRow = 0;
    int sumElemRow = 0;
    int count = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minRow += matrix[0, j];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElemRow += matrix[i, j];

        }
        if (sumElemRow < minRow)
        {
            minRow = sumElemRow;
            count = i;

        }
        Console.WriteLine($"Сумма {i + 1} строки = {sumElemRow}");
        sumElemRow = 0;
    }
    return count + 1;
}

int matrixRows = InputRead("Введите количество строк матрицы: ");
int matrixColumns = InputRead("Введите количество столбцов матрицы: ");
int[,] matrix = CreateMatrixRndInt(matrixRows, matrixColumns, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
int countMinSumRow = CountMinSumRow(matrix);
Console.WriteLine($"Строка с минимальной суммой элементов = {countMinSumRow}");