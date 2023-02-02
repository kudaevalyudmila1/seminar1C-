﻿// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 --> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {secondDigit}");


int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10; 
    if(firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}

int maxDigit = MaxDigit(number);
int maxDigit1 = MaxDigit(56);
int maxDigit2 = MaxDigit(78);
Console.WriteLine($"Наибольшая цифра числа {maxDigit}");
Console.WriteLine($"Наибольшая цифра числа {maxDigit1}");
Console.WriteLine($"Наибольшая цифра числа {maxDigit2}");