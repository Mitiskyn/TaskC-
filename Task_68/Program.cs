// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();
Console.WriteLine("Задайте два неотрицательных числа:");

Console.WriteLine("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int AckermannFunction(int number1, int number2)
{
  if (number1 == 0) return number2 + 1;
  if (number2 == 0) return AckermannFunction(number1 - 1, 1);
  return AckermannFunction(number1 - 1, AckermannFunction(number1, number2 - 1));
}

bool CheckNaturalNumber(int number1, int number2)
{
    return(number1 < 0 || number2 < 0);
}
if (CheckNaturalNumber(number1, number2))
{
  Console.WriteLine("Вы ввели отрицательные числа");
  return;
}

int ackermannFunction = AckermannFunction(number1, number2);

Console.Write($"Результат вычисления функции Аккермана чисел {number1} и {number2} = {ackermannFunction} ");
