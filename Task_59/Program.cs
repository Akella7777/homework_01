//Задача 59:
//Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент массива.

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
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[] IndexOfMinElem(int[,] matrix)
{
    int row = 0;
    int col = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= matrix[row, col])
            {
                row = i;
                col = j;
            }
        }
    }
    return new int[] { row, col };
}

int[,] DeleteRowColumns(int[,] matrix, int[] array)
{
    int[,] newArr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        if (m == array[0]) m++;
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            if (n == array[1]) n++;
            newArr[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newArr;
}


int matrixRows = InputRead("Введите количество строк матрицы: ");
int matrixColumns = InputRead("Введите количество столбцов матрицы: ");
int[,] matrix = CreateMatrixRndInt(matrixRows, matrixColumns, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] indexOfMinElem = IndexOfMinElem(matrix);
int[,] deleteRowColumns = DeleteRowColumns(matrix, indexOfMinElem);
PrintMatrix(deleteRowColumns);