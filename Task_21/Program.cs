// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("точек");
Console.Write("Первая точка A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторач точка A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Третья точка A: ");
int cA = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Третья точка B: ");
int cB = Convert.ToInt32(Console.ReadLine());


double distance = Distance(xA,yA,cA,xB,yB,cB);
Console.WriteLine(distance);


double Distance(int x1,int y1,int c1, int x2, int y2, int c2)
{
    double result = Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(c1-c2)*(c1-c2));
    double resultRound = Math.Round(result, 3, MidpointRounding.ToZero);
    return resultRound;
}