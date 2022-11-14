// . Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Ввeдите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) Console.WriteLine($"{number} - это понедельник");
else if (number == 2) Console.WriteLine($"{number} - это вторник");
else if (number == 3) Console.WriteLine($"{number} - это среда");
else if (number == 4) Console.WriteLine($"{number} - это четверг");
else if (number == 5) Console.WriteLine($"{number} - это пятница");
else if (number == 6) Console.WriteLine($"{number} - это суббота");
else if (number == 7) Console.WriteLine($"{number} - это воскресенье");
else Console.WriteLine("Ввeдите корректное число");