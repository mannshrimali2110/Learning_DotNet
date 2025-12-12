using System;

Console.WriteLine("Basic Class and Object Example");

class Person
{
    public string Name;
    public int Age;

    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
    }
}

Person mann = new Person();
mann.Name = "Mann Shrimali";
mann.Age = 21;
mann.Greet();

Person amit = new Person();
amit.Name = "Amit Verma";
amit.Age = 23;
amit.Greet();
