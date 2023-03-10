// Задача 55:
// Задайте двумерный массив.
// Напишите программу, которая поменяет строки на столбцы. 
// В случае, если это невозможно,
// программа должна вывести сообщение для пользователя
// программа должна вывести сообщение для пользователя

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

void ReplaceRowToColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}



int matrixRows = InputRead("Введите количество строк матрицы: ");
int matrixColumns = InputRead("Введите количество столбцов матрицы: ");
int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();

if (array2D.GetLength(0) != array2D.GetLength(1))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Количество строк отличается от количества столбцов. " +
                      "Количество строк и столбцов должно быть равное.");
    Console.ResetColor();
}
else
{
    ReplaceRowToColumns(array2D);
    PrintMatrix(array2D);
}
