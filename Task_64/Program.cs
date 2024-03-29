﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());


void NaturalNumbers(int num)
{
    if(num < 1) return;
    Console.Write($"{num} ");
    NaturalNumbers (num - 1);
}

bool CheckNaturalNumber(int num)
{
    return num >= 1;
}

if(CheckNaturalNumber(number))
{
    Console.Write($"N = {number} -> ");
    NaturalNumbers(number);
}
else 
Console.Write($"Вы ввели отрицательно число");