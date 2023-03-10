
// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10,100);
Console.WriteLine($"Cлучайное число из отрезка 10 - 99->{number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
 if(firstDigit > secondDigit) 
 Console.WriteLine($"Найбольшая цифтра числа ->{firstDigit}");
 else
  Console.WriteLine($"Найбольшая цифтра числа ->{secondDigit}");
