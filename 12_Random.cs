using System;

Console.WriteLine("Random Numbers");
Random rnd = new Random();

int randInt = rnd.Next(1, 101);
Console.WriteLine("Random integer between 1 and 100: " + randInt);

double randDouble = rnd.NextDouble();
Console.WriteLine("Random double between 0 and 1: " + randDouble);

Console.WriteLine("Random boolean example");
bool randBool = rnd.Next(0, 2) == 1;
Console.WriteLine("Random boolean: " + randBool);
Console.WriteLine("Random choice from an array");
string[] colors = { "ed", "Green", "Blue", "Yellow", "Purple" };
int randIndex = rnd.Next(colors.Length);
Console.WriteLine("Random color: " + colors[randIndex]);