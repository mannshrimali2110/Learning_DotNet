
Console.WriteLine("Arithmetic");
int a = 20;
int b = 7;

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

Console.WriteLine("Comparison");
Console.WriteLine(a > b);
Console.WriteLine(a < b);
Console.WriteLine(a == b);
Console.WriteLine(a != b);
Console.WriteLine(a >= b);
Console.WriteLine(a <= b);

Console.WriteLine("Logical");
bool isSunny = true;
bool isWeekend = false;

Console.WriteLine(isSunny && isWeekend);
Console.WriteLine(isSunny || isWeekend);
Console.WriteLine(!isSunny);

Console.WriteLine("Assignment");
int score = 50;

score += 10;
Console.WriteLine(score);

score -= 5;
Console.WriteLine(score);

score *= 2;
Console.WriteLine(score);

score /= 5;
Console.WriteLine(score);

Console.WriteLine("If Else");
int marks = 82;

if (marks >= 90)
    Console.WriteLine("Excellent");
else if (marks >= 70)
    Console.WriteLine("Good");
else
    Console.WriteLine("Needs Improvement");

Console.WriteLine("Switch Expression");
string day = "Tuesday";

var result = day switch
{
    "Monday" => "Start of Week",
    "Tuesday" => "Work Day",
    "Saturday" => "Weekend",
    "Sunday" => "Weekend",
    _ => "Regular Day"
};

Console.WriteLine(result);

