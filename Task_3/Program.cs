// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Веведите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number;

if (number == 1)
{
    Console.WriteLine("Monday");
}
if (number == 2)
{
    Console.WriteLine("Tuesday");
    
}
if (number == 3)
{
    Console.WriteLine("Wednesday");
    
}
if (number == 4)
{
    Console.WriteLine("Thursday");
    
}
if (number == 5)
{
    Console.WriteLine("Friday");
    
}
if (number == 6)
{
    Console.WriteLine("Saturday");
    
}
if (number == 7)
{
    Console.WriteLine("Sunday");
    
}
if (number > 7)
{
    Console.WriteLine("Нет дня недели");
}