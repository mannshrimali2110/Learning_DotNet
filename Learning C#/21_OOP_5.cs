using System;

Console.WriteLine("Inheritance Example");

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine("My name is " + Name + " and I am " + Age + " years old.");
    }
}

class Student : Person
{
    public string School;

    public Student(string name, int age, string school)
        : base(name, age)
    {
        School = school;
    }

    public void Study()
    {
        Console.WriteLine(Name + " is studying at " + School);
    }
}

class Teacher : Person
{
    public string Subject;

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine(Name + " teaches " + Subject);
    }
}

Person mann = new Person("Mann Shrimali", 21);
mann.Introduce();

Student amit = new Student("Amit Verma", 23, "St. Xavier's College");
amit.Introduce();
amit.Study();

Teacher sneha = new Teacher("Sneha Rao", 30, "Mathematics");
sneha.Introduce();
sneha.Teach();
