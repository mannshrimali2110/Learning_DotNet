using System;

Console.WriteLine("Interfaces Example");

interface IWorker
{
    void Work();
}

interface IReporter
{
    void Report();
}

class Developer : IWorker, IReporter
{
    public void Work()
    {
        Console.WriteLine("Developer is writing C# code");
    }

    public void Report()
    {
        Console.WriteLine("Developer is reporting progress");
    }
}

class Designer : IWorker
{
    public void Work()
    {
        Console.WriteLine("Designer is creating some random UI/UX designs");
    }
}

Developer dev = new Developer();
dev.Work();
dev.Report();

Designer des = new Designer();
des.Work();

Console.WriteLine("\nInterface Polymorphism");

IWorker w1 = new Developer();
IWorker w2 = new Designer();

w1.Work();
w2.Work();
