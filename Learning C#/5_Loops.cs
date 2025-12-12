using System;

Console.WriteLine("For Loop");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Count: " + i);
}

Console.WriteLine("While Loop");
int w = 1;
while (w <= 5)
{
    Console.WriteLine("While: " + w);
    w++;
}

Console.WriteLine("Do While Loop");
int d = 1;
do
{
    Console.WriteLine("DoWhile: " + d);
    d++;
}
while (d <= 5);

Console.WriteLine("Foreach Loop");
string[] cities = { "Ahmedabad", "Vejalpur", "Gandhinagar", "Surat" };
foreach (var city in cities)
{
    Console.WriteLine(city);
}
