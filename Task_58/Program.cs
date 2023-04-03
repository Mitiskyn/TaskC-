// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Вводим кол-во строчек:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим кол-во столбиков:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array2dA = CreateMatrixRndInt(a, b, 0, 10);
int[,] array2dB = CreateMatrixRndInt(a, b, 0, 10);
int[,] matrixMultiply = MatrixMultiply(array2dA, array2dB);

Console.WriteLine("Матрица A:");
PrintMatrix(array2dA);
Console.WriteLine();

Console.WriteLine("Матрица B:");
PrintMatrix(array2dB);
Console.WriteLine();

Console.WriteLine("Результаты двух матриц будет:");
PrintMatrix(matrixMultiply);


int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
{
    int row = (matrixA.GetLength(0) >= matrixB.GetLength(0)) ? matrixA.GetLength(0) : matrixB.GetLength(0);
    int columns = (matrixA.GetLength(1) >= matrixB.GetLength(1)) ? matrixA.GetLength(1) : matrixB.GetLength(1);
    int[,] matrixMultiply = new int[row, columns];
    if(matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int n = 0; n < matrixB.GetLength(0); n++)
                {
                    matrixMultiply[i, j] += matrixA[i, n] * matrixB[n, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Матрицу A и B не возможно умножить");
    }
    return matrixMultiply;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)   //rows
  {
    for (int j = 0; j < matrix.GetLength(1); j++)  //columns
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
      Console.Write($"{matrix[i, j],3} ");
    }
    Console.WriteLine("|");
  }
}