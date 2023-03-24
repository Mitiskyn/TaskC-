﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();

int decimal1 = 45;
int result = DecToBinInt(decimal1);

Console.WriteLine(result);

// Через String

// string DecToBinString(int decimalNumber)
// {
//     if (decimalNumber == 0 || decimalNumber == 1)
//     {
//         return decimalNumber.ToString();
//     } 

//     string dec = string.Empty;
//     while (decimalNumber > 0)
//     {
//         dec = decimalNumber % 2 + dec;
//         decimalNumber /= 2;                
//     }
//     return dec;
// }

//Через Int

int DecToBinInt(int decimalNumber)
{
    if (decimalNumber == 0 || decimalNumber == 1)
    {
        return decimalNumber;
    } 

    int dec = 0;
    int i = 1;
    while (decimalNumber > 0)
    {
        dec = dec + decimalNumber % 2 * i;        
        decimalNumber /= 2; 
        i *= 10;               
    }
    return dec;
}