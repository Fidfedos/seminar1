﻿//Напишете програму которая на вход принимает одно число N а на выходе показывает все целые в промежутке от N до -N
//4 -> -4 -3 -2 -1 0 1 2 3 4
//2 -> -2 -1 0 1 2

Console.WriteLine("Введите N ");
int N = Convert.ToInt32(Console.ReadLine());
N = N < 0 ? N*(-1) : N;
    for(int i = -N; i <= N; i++)
    {
        Console.Write(i);
        if(i != N)
        {
            Console.Write(",  ");

        }

    }