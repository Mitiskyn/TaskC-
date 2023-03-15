// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());


NumberCube(number);
void NumberCube(int number)
{
    int count = 1;
while(count <= number)
    {
    int squad = count * count * count;
    Console.WriteLine($"{count,5}->{squad,10}");
    count++;
    }
}