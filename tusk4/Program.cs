//Написать програму которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
//456 -> 6
//782 -> 2

Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int result = a % 10;
result = result < 0 ? result*(-1) : result;
Console.WriteLine("Последняя цифра: " + (a %10));
