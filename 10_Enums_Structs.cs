using System;

Console.WriteLine("Enums");
enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
Days today = Days.Tuesday;
Console.WriteLine(today);
Console.WriteLine((int)today);

Console.WriteLine("Structs");
struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}

Point p = new Point(10, 20);
p.Display();

Console.WriteLine("Nullable Types");
int? nullableInt = null;
Console.WriteLine(nullableInt.HasValue);
nullableInt = 50;
Console.WriteLine(nullableInt.Value);

Console.WriteLine("Exception Handling");

try
{
    int a = 10;
    int b = 0;
    int c = a / b;
    Console.WriteLine(c);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Error: " + e.Message);
}
finally
{
    Console.WriteLine("Finally block executed");
}
