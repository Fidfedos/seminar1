﻿//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// && - и
// || - или
Console.WriteLine("Введите кординату по точки x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату по точки y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0 )
{
    Console.WriteLine("Точка находиться в первой кординатной четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находиться во второй кординатной четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находиться в третей кординатной четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находиться в четвёртой кординатной четверти");
}
else 
{
    ("Не возможно определить кординаты четверти");
}   