// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Введите натуральное число:");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (count > 0)
{
    int n = 1;
    int Square(int num)
    {
        return num * num;
    }

    while (n <= count)
    {
        int square = Square(n);
        Console.WriteLine(square);
        n++;
    }
}
else Console.WriteLine("Число не является натуральным");


Console.WriteLine("Введите натуральное число ->");
int number =Convert.ToInt32(Console.ReadLine());


// void Quadre(int num)
// {
// int num1 = 1;
// while (num1 <= num)
// {
// int square = num1 * num1;
// Console.WriteLine($"{num1, 4} {square, 4}");
// num1 ++;
// }
// }
// if (number > 0)
// Quadre(number);
// else Console.WriteLine("Число не является натуральным");