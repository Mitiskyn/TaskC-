// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,999);
Console.WriteLine($"Cлучайное число из отрезка 100 - 1000->{number}");

int finalResult = RemoveSecondDigit(number);

int RemoveSecondDigit(int num)
{
 int firstDigit = num / 100;
 int thirdDigit = num % 100;
 int result = firstDigit * 10 + thirdDigit;
 return result;
}

Console.WriteLine(finalResult);
