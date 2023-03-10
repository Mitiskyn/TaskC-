// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.Write("Введите первое число: ");

int firstNumber = ReadConsole();

Console.Write("Введите второе число: ");

int secondNumber = ReadConsole();

int result = IsMultiplicity(firstNumber, secondNumber) ;

if(result == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {result}");
}

int IsMultiplicity(int number1, int number2)
{
    return number1 % number2;    
}

int ReadConsole()
{
    var str = Console.ReadLine();
    int number = Convert.ToInt32(str);

    return number;
}