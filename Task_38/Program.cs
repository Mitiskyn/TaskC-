// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndInt(10, 0, 100, 1);
double maxNumber = MaxNumber(array);
double minNumber = MinNumber(array);
double minMaxDifference = MinMaxDifference(minNumber, maxNumber);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент: {maxNumber}");
Console.WriteLine($"Минимальный элемент: {minNumber}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: = {minMaxDifference}");

double MaxNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double MinNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

double MinMaxDifference(double min, double max)
{
    double difference = max - min;
    difference = Math.Round(difference, 1);
    return difference;
}

double[] CreateArrayRndInt(int size, int min, int max, int round = 1)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
