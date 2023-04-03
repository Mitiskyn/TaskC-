// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



Console.Clear();

Console.WriteLine("Вводим кол-во строчек:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим кол-во столбиков:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array2d = CreateMatrixRndInt(m, n, 0, 10);
int rowMatrixMinSum = RowMatrixMinSum(array2d);

Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine($"Строка с найменьшей суммой элементов: {rowMatrixMinSum}");


int RowMatrixMinSum(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow[i] += matrix[i, j];
        }
        Console.WriteLine($"Сумма чисел в {i + 1}-строке = {sumRow[i]}");
    }
    
    int sum = sumRow[0];
    int minRow = 0;

    for (int i = 0; i < sumRow.Length; i++)
    {
        if (sumRow[i] < sum)
        {
            sum = sumRow[i];
            minRow = i;
        }
    }
    return minRow + 1;
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