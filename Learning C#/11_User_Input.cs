using System;

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);

Console.WriteLine("Enter your age:");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);
Console.WriteLine("You are " + age + " years old");

Console.WriteLine("Enter two numbers to add:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Sum: " + (num1 + num2));

Console.WriteLine("Enter a number to check even/odd:");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
    Console.WriteLine(n + " is even");
else
    Console.WriteLine(n + " is odd");

Console.WriteLine("Try parsing with TryParse:");
Console.WriteLine("Enter a number:");
bool success = int.TryParse(Console.ReadLine(), out int value);
if (success)
    Console.WriteLine("You entered: " + value);
else
    Console.WriteLine("Invalid number");
