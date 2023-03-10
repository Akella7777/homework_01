// Задача 58:
// Задайте две матрицы.
// Напишите пограмму, которая будет находит произведение двух матриц.

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
            if (i < matrix.GetLength(1)) Console.Write($"{matrix[i, j],3} ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] newMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int k = 0; k < matrixB.GetLength(0); k++)
                {
                        newMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
    }
    return newMatrix;
}


int matrixRowsA = InputRead("Введите количество строк матрицы A: ");
int matrixColumnsA = InputRead("Введите количество столбцов матрицы A: ");
int matrixRowsB = InputRead("Введите количество строк матрицы B: ");
int matrixColumnsB = InputRead("Введите количество столбцов матрицы B: ");
int[,] matrixA = CreateMatrixRndInt(matrixRowsA, matrixColumnsA, 1, 5);
int[,] matrixB = CreateMatrixRndInt(matrixRowsB, matrixColumnsB, 1, 5);
PrintMatrix(matrixA);
Console.WriteLine("-------------------");
PrintMatrix(matrixB);
Console.WriteLine();
int[,] newMatrix = MultiplicationMatrix(matrixA, matrixB);
if (matrixA.GetLength(1) == matrixB.GetLength(0)) PrintMatrix(newMatrix);
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Количество столбцов матрицы A не совпадает с количеством строк матрицы B. " +
                        "Матрицы перемножить нельзя");
    Console.ResetColor();
}