using System;

Console.WriteLine("Abstract Class Example");

abstract class Animal
{
    public string Name;

    public Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine(Name + " is eating");
    }

    public abstract void MakeSound();
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine(Name + " barks");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine(Name + " meows");
    }
}

Dog dog = new Dog("Bruno");
dog.Eat();
dog.MakeSound();

Cat cat = new Cat("Luna");
cat.Eat();
cat.MakeSound();
