﻿//  Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int result = 0;
if (number > 99 && number < 1000)
{
    result = number % 10;
    Console.WriteLine($"Последняя цифра числа: {result} ");
}
else Console.WriteLine("Введите трехзначное число: ");