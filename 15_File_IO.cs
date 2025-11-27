using System;
using System.IO;

string path = "testfile.txt";

Console.WriteLine("Writing to file");
File.WriteAllText(path, "Hello Mann!\nWelcome to C# File I/O.");

Console.WriteLine("Appending to file");
File.AppendAllText(path, "\nThis line is appended.");

Console.WriteLine("Reading entire file");
string content = File.ReadAllText(path);
Console.WriteLine(content);

Console.WriteLine("Reading file line by line");
string[] lines = File.ReadAllLines(path);
foreach (var line in lines)
{
    Console.WriteLine(line);
}

Console.WriteLine("Check if file exists");
Console.WriteLine(File.Exists(path) ? "File exists" : "File does not exist");

Console.WriteLine("Deleting file");
File.Delete(path);
Console.WriteLine(File.Exists(path) ? "File exists" : "File deleted");
