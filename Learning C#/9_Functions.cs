using System;

Console.WriteLine("Simple Method");
void Greet()
{
    Console.WriteLine("Hello Mann!");
}
Greet();

Console.WriteLine("Method with Parameters");
void PrintSum(int a, int b)
{
    Console.WriteLine(a + b);
}
PrintSum(10, 20);

Console.WriteLine("Method with Return Value");
int Multiply(int x, int y)
{
    return x * y;
}
int result = Multiply(5, 6);
Console.WriteLine(result);

Console.WriteLine("Method Overloading");
int Add(int a, int b)
{
    return a + b;
}
double Add(double a, double b)
{
    return a + b;
}
Console.WriteLine(Add(5, 10));
Console.WriteLine(Add(4.5, 3.2));

Console.WriteLine("Default Parameters");
void Display(string name = "AnyNamee")
{
    Console.WriteLine("Hello " + name);
}
Display();
Display("Mann");

Console.WriteLine("Named Arguments");
void Info(string name, int age)
{
    Console.WriteLine(name + " is " + age + " years old");
}
Info(age: 22, name: "Mann");
