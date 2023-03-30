// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет





int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);

Console.Write("Введите номер строки позиции элемента: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца позиции элемента: ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());

bool digitElemetMatrix = DigitElemetMatrix(array2d, columnsNumber, rowNumber);

Console.Write($"{rowNumber} {columnsNumber} ->");
Console.WriteLine(digitElemetMatrix ? array2d[rowNumber, columnsNumber] : "Такого позиции элемента нету");


bool DigitElemetMatrix(int[,]matrix, int row, int columns)
{
    if(matrix.GetLength(0) >= row && matrix.GetLength(1) >= columns && row >= 0 && columns >= 0 )
    {
        int result = matrix[row, columns];
        return true;
    }
    else return false;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                          
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}