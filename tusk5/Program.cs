//Написать програму которая на вход принимает два числа и выдаёт какое число больше а какое меньше 
// a = 5 b = 7 -> max 7
// a = 5 n = 7 -> min 7
int max = 0;
int min = 0;

Console.Write("Введите первое число ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int secondtnumber = Convert.ToInt32(Console.ReadLine());

    if (firstnumber > secondtnumber) 
    {
        max = firstnumber;
        min = secondtnumber;
    }
else 
{
    max = secondtnumber;
    min = firstnumber;
}
Console.WriteLine("max = " + max );
Console.Write("min = " + min );