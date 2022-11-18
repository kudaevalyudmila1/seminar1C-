// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число  {number}");

int MinusMiddle(int num)
{
int first = num / 100;
int second = num % 10;
int result = first * 10 + second;
return result;
}
int result = MinusMiddle(number);
Console.WriteLine($"Число:  {result}");

