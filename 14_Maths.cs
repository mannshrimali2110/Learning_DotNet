using System;

Console.WriteLine("Math Utilities");

int a = 10;
int b = 3;

Console.WriteLine("Max: " + Math.Max(a, b));
Console.WriteLine("Min: " + Math.Min(a, b));
Console.WriteLine("Power: " + Math.Pow(a, b));
Console.WriteLine("Square Root: " + Math.Sqrt(a));
Console.WriteLine("Absolute: " + Math.Abs(-a));
Console.WriteLine("Round: " + Math.Round(3.7));
Console.WriteLine("Ceiling: " + Math.Ceiling(3.2));
Console.WriteLine("Floor: " + Math.Floor(3.8));

Console.WriteLine("Trigonometry Example");
double angle = 30;
Console.WriteLine("Sin: " + Math.Sin(angle * Math.PI / 180));
Console.WriteLine("Cos: " + Math.Cos(angle * Math.PI / 180));
Console.WriteLine("Tan: " + Math.Tan(angle * Math.PI / 180));   