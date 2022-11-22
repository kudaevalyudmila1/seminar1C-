// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
//  Выполнить с помощью числовых операций (целочисленное
//  деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (count < 100000 && count > 9999)
{
    int num1 = 0;
    int num5 = 0;
    int num2 = 0;
    int num4 = 0;
    num1 = count / 10000;
    num5 = count % 10;
    num2 = count / 1000 % 10;
    num4 = count % 100 / 10;
    if (num1 == num5 && num2 == num4)
        Console.WriteLine($"{count} -> да");
    else Console.WriteLine($"{count} -> нет");
}
else Console.WriteLine("Введенное число не пятизначное");