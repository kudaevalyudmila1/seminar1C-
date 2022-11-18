Console.WriteLine("Введите первое число:");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int second = Convert.ToInt32(Console.ReadLine());

int Division(int num1, int num2)
{
     return num1 % num2; 
}
int result = Division(first, second);
if (result == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток {result}");
