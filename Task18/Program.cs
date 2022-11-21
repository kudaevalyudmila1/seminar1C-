Console.WriteLine("Введите номер четверти:");
int number = Convert.ToInt32(Console.ReadLine());

string Range (int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x > 0, y < 0";
    if (num == 4) return "x < 0, y < 0";
    return "Введены некорректные данные";
}
string result = Range(number);
Console.WriteLine($"Вероятный диапазон координат:{result}");
