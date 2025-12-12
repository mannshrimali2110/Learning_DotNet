Console.WriteLine("Calculator");

int x = 15;
int y = 5;
string op = "*";

var calc = op switch
{
    "+" => x + y,
    "-" => x - y,
    "*" => x * y,
    "/" => y != 0 ? x / y : 0,
    "%" => x % y,
    _ => 0
};

Console.WriteLine(calc);
