// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {factorial}");


int Factorial(int num)
{
    int product = 1;
    for(int count = 2; count <= num; count++)
    {
        product = product*count;
    }
    return product;
}

