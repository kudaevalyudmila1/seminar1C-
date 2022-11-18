// Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет. 
//  Выполнить с помощью числовых операций (целочисленное 
//  деление, остаток от деления).
//  645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Ввeдите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
number1 = Math.Abs(number1);

int Thirdnumber(int num)
{
    return num % 10;
}
if (number1 > 100)
{
    while (number1 > 1000)
    {
        number1 = number1 / 10;
    }
    int res = Thirdnumber(number1);
    Console.Write($"{number}-> {res} ");
}
else Console.WriteLine("Третьей цифры нет ");