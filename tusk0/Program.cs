// Напишите програму которая на вход принимает число и выдаёт его квадрат (число умноженное само на себя)

// Например 
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите число");
String user = Console.ReadLine();
int number = Convert.ToInt32(user);

// Более сокращённый вариант 
//int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine(result);
//Можно сделать так 
//Console.WriteLine(number * number);
