//Напишите програму которая принимает на вход три чила и выдаёт максимальное из этих чисел (сраавнить с каждым )
//2 3 7 -> 7
//1 9 6 -> 9

int max = 0;

Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третие число ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > max)
{
    max = a;
}
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}

Console.WriteLine("max = " + max);
