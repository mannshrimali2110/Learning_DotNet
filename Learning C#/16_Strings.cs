using System;

Console.WriteLine("String Basics");
string firstName = "Mann";
string lastName = "Shrimali";

Console.WriteLine("Full Name: " + firstName + " " + lastName);
Console.WriteLine("Length of firstName: " + firstName.Length);
Console.WriteLine("Uppercase: " + firstName.ToUpper());
Console.WriteLine("Lowercase: " + lastName.ToLower());

Console.WriteLine("Substring");
Console.WriteLine(firstName.Substring(1, 2));

Console.WriteLine("IndexOf & LastIndexOf");
Console.WriteLine(firstName.IndexOf('a'));
Console.WriteLine(lastName.LastIndexOf('i'));

Console.WriteLine("Replace");
string newName = firstName.Replace("Mann", "Riya");
Console.WriteLine(newName);

Console.WriteLine("Contains & StartsWith & EndsWith");
Console.WriteLine(firstName.Contains("an"));
Console.WriteLine(firstName.StartsWith("M"));
Console.WriteLine(lastName.EndsWith("i"));

Console.WriteLine("Trim & Pad");
string padded = "   hello   ";
Console.WriteLine("Trim: '" + padded.Trim() + "'");
Console.WriteLine("PadLeft: '" + firstName.PadLeft(10) + "'");
Console.WriteLine("PadRight: '" + firstName.PadRight(10) + "'");

Console.WriteLine("Split & Join");
string sentence = "C# is similar to c++ but kinda tricky";
string[] words = sentence.Split(' ');
foreach (var word in words)
{
    Console.WriteLine(word);
}
string joined = string.Join("-", words);
Console.WriteLine(joined);

Console.WriteLine("String Interpolation");
Console.WriteLine($"Hello {firstName} {lastName}, welcome to C#!");
