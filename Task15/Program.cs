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
    if (num == 1) Console.WriteLine($"{num} - это понедельник");
    else if (num == 2) Console.WriteLine($"{num} - это вторник");
    else if (num == 3) Console.WriteLine($"{num} - это среда");
    else if (num == 4) Console.WriteLine($"{num} - это четверг");
    else if (num == 5) Console.WriteLine($"{num} - это пятница");
    else if (num == 6) Console.WriteLine($"{num} - это суббота");
    else if (num == 7) Console.WriteLine($"{num} - это воскресенье");
    return num;
}

if (number > 0 && number < 8)
{
    int res = Dayweek(number);
}
else Console.WriteLine("Ввeдите верное число: ");