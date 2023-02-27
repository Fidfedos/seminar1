// Напишите программу которая на вход принимает 2 числа и проверяет является ли первое число квадратом второго 
//a = 25 b = 5 -> YES
//a = 2 b = 10 -> NO

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(b*b == a)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");
