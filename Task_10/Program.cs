// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ShowSecondNumber(int number)
{
    int secondNumber = number / 10;
    int result = secondNumber % 10;
    return result;
}

Console.WriteLine("Введите Трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
int secondNumber = ShowSecondNumber(number);
Console.WriteLine($"Вторая цифра трехзначного числа {secondNumber}");
}
else
Console.WriteLine("Дружок пирожек, это не трехзначное число, трех значное это где три числа допусти 123");

