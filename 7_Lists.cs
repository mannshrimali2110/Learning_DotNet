using System;
using System.Collections.Generic;

Console.WriteLine("Creating a List");
var fruits = new List<string> { "Apple", "Banana", "Mango" };
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("Add & Remove Elements");
fruits.Add("Orange");
fruits.Remove("Banana");
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("Insert Element at Index 1");
fruits.Insert(1, "Grapes");
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("RemoveAt Index 0");
fruits.RemoveAt(0);
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("Access by Index");
Console.WriteLine(fruits[0]);

Console.WriteLine("Count of Elements");
Console.WriteLine(fruits.Count);

Console.WriteLine("Looping with For");
for (int i = 0; i < fruits.Count; i++)
{
    Console.WriteLine(fruits[i]);
}

Console.WriteLine("Contains Method");
Console.WriteLine(fruits.Contains("Mango"));

Console.WriteLine("IndexOf & LastIndexOf");
fruits.Add("Mango");
Console.WriteLine(fruits.IndexOf("Mango"));
Console.WriteLine(fruits.LastIndexOf("Mango"));

Console.WriteLine("Sort & Reverse");
fruits.Sort();
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}
fruits.Reverse();
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("GetRange Example");
var subList = fruits.GetRange(1, 2);
foreach (var fruit in subList)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("Clear List");
fruits.Clear();
Console.WriteLine(fruits.Count); // Should be 0
