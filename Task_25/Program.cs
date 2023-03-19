// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int natureDigit = NatureDigit(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {natureDigit}");


int NatureDigit(int numA, int numB)
{
    int nnum = numA;
    if(numB==0) nnum = 1;

    for(int i = 1; i < numB; i++)
    {
        checked
        {
        nnum = nnum * numA;
        }
    }
    return nnum;

}