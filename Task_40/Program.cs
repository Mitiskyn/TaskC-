// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Веведите первую сторону треугольника: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Веведите вторую сторону треугольника: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Веведите третью сторону треугольника: ");
int numb3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTringle(numb1, numb2, numb3);

Console.WriteLine(result ? "Cуществует" : "Не существует");

bool IsExistTringle(int n1, int n2, int n3 )
{
    return n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2;
    
}