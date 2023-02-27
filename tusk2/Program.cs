// Напишите програму которая будет выдавать названия дня недели по заданному номеру  
// 3 -> среда
// 4 -> четвверг

string []days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write("Введите номер дня ");
int number0Day = Convert.ToInt32(Console.ReadLine());
if(number0Day > 7 | number0Day < 1)
{
 Console.WriteLine("Вы ввели нне правильный номер дня");
}
else Console.WriteLine(days[number0Day - 1]);