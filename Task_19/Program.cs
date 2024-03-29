﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * -1;
if (number < 10000 || number > 100000)
{
Console.WriteLine("Не является пятизначным числом");
}
else
{  bool palindrome = Palindrome(number);
    Console.WriteLine();
    Console.WriteLine(palindrome ? "Число является палиндромом" : "Число не является палиндромом");
}
    
    
    bool Palindrome(int num)
{
    if (num < 10)
        return false;
    int initNum = num;
    int revNum = 0;
    while (num > 0)
    {
        revNum = revNum * 10 + num % 10;
        num /= 10;
    }
    return initNum == revNum;
}
   


    

