﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите первое целое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int z = Convert.ToInt32(Console.ReadLine());

int max = x;
if (y > max)
    {
        max = y;
    }
            if (z>max)
            {
                max = z;
                Console.WriteLine("Максимальное число " +max);
            }
            else Console.WriteLine("Максимальное число " +max);
