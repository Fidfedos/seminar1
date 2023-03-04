//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

//Возведение в степень числа.
// int a = 5;
// int b = 3;
// double res = Math.pow(a,b);
// Console.WriteLine("res");
//AB = √(xb - xa)2 + (yb - ya)2

int getInt()
{
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = getInt();
int y1 = getInt();
int x2 = getInt();
int y2 = getInt();
double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine(d);