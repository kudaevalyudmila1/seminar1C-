//  Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine("Введите натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());

int number = 1;
while (number <= n)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    
    }
    number++;
}
