//  Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1>number2) Console.WriteLine($"Максимальное число: {number1} Минимальное число: {number2}");
if (number2>number1) Console.WriteLine($"Максимальное число: {number2} Минимальное число: {number1}");
else Console.WriteLine($"Число: {number2} равно числу: {number1}");