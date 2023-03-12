// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdNumber(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while(number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}

Console.WriteLine("Введите любое число от 1 до бесконечности");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) number = -number;
if(ThirdNumber(number)== -1)
Console.WriteLine("Нет Третий цыфры");
else
{
Console.WriteLine($"Третья цифра данного числа {ThirdNumber(number)} ");
}