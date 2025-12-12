using System;

Console.WriteLine("Constructors Example");

class Person
{
    public string Name;
    public int Age;

    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
    }
}

Person defaultPerson = new Person();
defaultPerson.Greet();

Person mann = new Person("Mann Shrimali", 21);
mann.Greet();

Person amit = new Person("Amit Verma", 23);
amit.Greet();
