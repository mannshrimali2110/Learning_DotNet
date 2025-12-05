using System;

Console.WriteLine("Access Modifiers Example");

class Person
{
    public string Name;
    private int Age;
    protected string City;
    internal string Country;

    public Person(string name, int age, string city, string country)
    {
        Name = name;
        Age = age;
        City = city;
        Country = country;
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name + " from " + City + ", " + Country);
        Console.WriteLine("Age (private): " + Age);
    }
}

class Student : Person
{
    public Student(string name, int age, string city, string country)
        : base(name, age, city, country)
    {
    }

    public void ShowCity()
    {
        Console.WriteLine("Protected City: " + City);
    }
}

Person mann = new Person("Mann Shrimali", 21, "Ahmedabad", "India");
mann.ShowInfo();
Console.WriteLine("Internal Country Access: " + mann.Country);

Student amit = new Student("Random person", 23, "Mumbai", "India");
amit.ShowCity();
