using System;

Console.WriteLine("Polymorphism Example");

Console.WriteLine("\nMethod Overloading");

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

Calculator calc = new Calculator();
Console.WriteLine(calc.Add(5, 10));
Console.WriteLine(calc.Add(4.5, 3.2));
Console.WriteLine(calc.Add(1, 2, 3));

Console.WriteLine("\nMethod Overriding");

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}

Animal genericAnimal = new Animal();
genericAnimal.Speak();

Dog dog = new Dog();
dog.Speak();

Cat cat = new Cat();
cat.Speak();

Console.WriteLine("\nPolymorphism through Base Class Reference");

Animal a1 = new Dog();
Animal a2 = new Cat();

a1.Speak();
a2.Speak();
