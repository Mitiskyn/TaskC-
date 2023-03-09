Console.Write("Веведите целое число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Веведите целое число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int max =0;

{
    if(numberA > numberB)
    {
        Console.WriteLine($"max={numberA}");
        Console.WriteLine($"min={numberB}");
    }
    else
    {
        Console.WriteLine($"max={numberB}");
        Console.WriteLine($"min={numberA}");
    }
}
    
