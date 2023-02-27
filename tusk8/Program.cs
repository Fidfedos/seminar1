//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число N : ");
int a = Convert.ToInt32(Console.ReadLine());

int b = 2;

if(a > 1)
{
    while(b <= a)
    {
        Console.Write(b + " ");
        b = b + 2;
    }
}
