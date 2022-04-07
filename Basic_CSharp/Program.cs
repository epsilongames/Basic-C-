// See https://aka.ms/new-console-template for more information

//methods
// will ask for 3 inputs -> first num, arithmatic operator, second num.

while (true)
{
    Console.WriteLine("Enter First Number :");
    int a1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Arithmatic Operator :");
    string sign = Console.ReadLine();
    Console.WriteLine("Enter Second Number :");
    int a2 = int.Parse(Console.ReadLine());

    switch (sign)
    {
        case "+":
            Add(a1, a2);
            break;
        case "-":
            Subtract(a1, a2);
            break;
        case "*":
            Multiply(a1, a2);
            break;
        case "/":
            Division(a1, a2);
            break;
    }
}

//method Define.
void Add(int a, int b)
{
    int result = a + b;
    Console.WriteLine($"Result of {a} + {b} = {result}");
}
void Subtract(int a, int b)
{
    int result = a - b;
    Console.WriteLine($"Result of {a} - {b} = {result}");
}
void Multiply(int a, int b)
{
    int result = a * b;
    Console.WriteLine($"Result of {a} * {b} = {result}");
}
void Division(int a, int b)
{
    int result = a / b;
    Console.WriteLine($"Result of {a} / {b} = {result}");
}