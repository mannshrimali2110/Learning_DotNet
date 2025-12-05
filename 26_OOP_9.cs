using System;

Console.WriteLine("Static Members Example");

class Counter
{
    public static int Count = 0;

    public Counter()
    {
        Count++;
    }

    public static void ShowCount()
    {
        Console.WriteLine("Total objects created: " + Count);
    }
}

class MathUtilities
{
    public static double Square(double n)
    {
        return n * n;
    }
}

class Person
{
    public string Name { get; set; }
    public static string Planet = "Earth";

    public void Show()
    {
        Console.WriteLine(Name + " lives on " + Planet);
    }
}

Counter c1 = new Counter();
Counter c2 = new Counter();
Counter c3 = new Counter();

Counter.ShowCount();

Console.WriteLine("Square of 5: " + MathUtilities.Square(5));

Person mann = new Person { Name = "Mann Shrimali" };
mann.Show();

Person amit = new Person { Name = "Ezu Rohit" };
amit.Show();

Person.Planet = "Mars";

mann.Show();
amit.Show();
