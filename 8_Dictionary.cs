using System;
using System.Collections.Generic;

Console.WriteLine("Creating a Dictionary");
var studentAges = new Dictionary<string, int>
{
    { "Mann", 21 },
    { "Yash", 22 },
    { "Amit", 20 }
};

Console.WriteLine("Access Values by Key");
Console.WriteLine(studentAges["Mann"]);

Console.WriteLine("Add & Update Entries");
studentAges["Rohit"] = 23;
studentAges["Amit"] = 21; // update existing key

foreach (var kvp in studentAges)
{
    Console.WriteLine(kvp.Key + ": " + kvp.Value);
}

Console.WriteLine("Check Key Exists");
Console.WriteLine(studentAges.ContainsKey("Riya"));

Console.WriteLine("Check Value Exists");
Console.WriteLine(studentAges.ContainsValue(21));

Console.WriteLine("Remove Entry");
studentAges.Remove("Riya");

Console.WriteLine("Loop Remaining Entries");
foreach (var kvp in studentAges)
{
    Console.WriteLine(kvp.Key + ": " + kvp.Value);
}

Console.WriteLine("Count of Entries");
Console.WriteLine(studentAges.Count);

Console.WriteLine("Get Keys and Values separately");
foreach (var key in studentAges.Keys)
{
    Console.WriteLine("Key: " + key);
}
foreach (var value in studentAges.Values)
{
    Console.WriteLine("Value: " + value);
}

Console.WriteLine("TryGetValue Example");
if (studentAges.TryGetValue("Mann", out int mannAge))
{
    Console.WriteLine("Mann's Age: " + mannAge);
}
else
{
    Console.WriteLine("Key not found");
}

Console.WriteLine("Clear Dictionary");
studentAges.Clear();
Console.WriteLine("Count after clear: " + studentAges.Count);
