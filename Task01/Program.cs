//  Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
Console.WriteLine("Введите первое число:");
Console.WriteLine("Введите второе число:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 * number2 == number1)

    Console.WriteLine($"Число {number1} является квадратом {number2}");

else

    Console.WriteLine($"Число {number1}  не является квадратом {number2}");
