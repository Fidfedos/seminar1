//Напишиет програму которая на вход принимает число A и выдаёт сумму чисел от 1 до A
// 7 -> 28
// 4 ->10
// 8 -> 36

int ReadIntNumber(string messegeToUser)
{
    Console.WriteLine(messegeToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int sumfrom(int a )
{
    int suma = 0;

    for(int i = 1; i <= a; i++)
    {
        suma = suma + i;
    
    }
    return suma;
}
int number = ReadIntNumber ("Введите первое число а");
int result = sumfrom(number);
Console.WriteLine($"Сума чисел от 1 до {ReadIntNumber} = {result}");


