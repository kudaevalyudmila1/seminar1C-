// Напишите программу, которая принимает на вход
//  цифру, обозначающую день недели, и проверяет, 
//  является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Ввeдите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Dayweek(int num)
{
    if (num == 6 || num == 7) Console.WriteLine($"{num} - это выходной день");
    else Console.WriteLine($"{num} - этот день не является выходным");

    return num;
}

if (number > 0 && number < 8)
{
    int res = Dayweek(number);
}
else Console.WriteLine("Ввeдите верное число: ");