﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(numb);

for(int i = 1; i <= numb; i++)
{
    System.Console.WriteLine(Math.Pow(i,3));
}
