
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Веведите целое число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Веведите целое число B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Веведите целое число C");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if( max > numberB)
{
    if(max > numberC)
    {
        Console.WriteLine($"max={max}");
    }
else

    max = numberC;
    Console.WriteLine($"max={max}");

}
else
{
    max = numberB;
    if(max > numberC)
    {
        Console.WriteLine($"max={max}");
    }
    else
    {
        max = numberC;
        Console.WriteLine($"max={max}");
    }
}