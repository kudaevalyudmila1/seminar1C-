//  Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
number1 = Math.Abs(number1);
if (number1 > 0)
{
    int number2 = -number1;
    while (number2 <= number1)
    {
        Console.WriteLine(number2);
        number2 = number2 + 1;
    }
}
else Console.WriteLine("Введите натуральное число");