//Задача 47. 
//Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Clear();

int InputRead(string msg)
{
    Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[,] CreateMatrixRndDouble(int row, int columns, int min, int max)
{
    double[,] matrix = new double[row, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(1)) Console.Write($"{matrix[i, j],7} ");
            else Console.Write($"{matrix[i, j],7}");
        }
        Console.WriteLine("|");
    }
}

int matrixRows = InputRead("Введите количество строк: ");
int matrixColumns = InputRead("Введите количество столбцов: ");
double[,] array2D = CreateMatrixRndDouble(matrixRows, matrixColumns, -100, 100);
PrintMatrix(array2D);