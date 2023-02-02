﻿// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точек:");
Console.Write("X1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double Pifagor(int xa, int ya, int xb, int yb, int za, int zb)
{
    return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
}
double res = Math.Round(Pifagor(x1, y1, x2, y2, z1, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);