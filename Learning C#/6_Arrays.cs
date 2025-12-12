using System;

Console.WriteLine("Single-Dimensional Array");
int[] numbers = { 10, 20, 30, 40, 50 };
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

Console.WriteLine("Access Elements");
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[3]);

Console.WriteLine("Update Value");
numbers[2] = 99;
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

Console.WriteLine("Length");
Console.WriteLine(numbers.Length);

Console.WriteLine("Sort Array");
Array.Sort(numbers);
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

Console.WriteLine("Reverse Array");
Array.Reverse(numbers);
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

Console.WriteLine("IndexOf & LastIndexOf");
Console.WriteLine(Array.IndexOf(numbers, 40));
Console.WriteLine(Array.LastIndexOf(numbers, 40));

Console.WriteLine("Multi-Dimensional Array");
int[,] grid = 
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};

Console.WriteLine(grid[0, 0]);
Console.WriteLine(grid[1, 2]);

Console.WriteLine("Loop 2D Array");
for (int i = 0; i < grid.GetLength(0); i++)
{
    for (int j = 0; j < grid.GetLength(1); j++)
    {
        Console.Write(grid[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Flatten 2D Array using GetLength and loop");
int rows = grid.GetLength(0);
int cols = grid.GetLength(1);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(grid[i, j] + " ");
    }
    Console.WriteLine();
}
