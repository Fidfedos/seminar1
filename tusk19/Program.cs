﻿// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void A (string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - Да.");
  }
  else Console.WriteLine($"Ваше число: {number} - Нет.");
}

if (number!.Length == 5)
{
  A (number);
}
else Console.WriteLine($"Введи правильное число");
