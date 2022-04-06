// See https://aka.ms/new-console-template for more information


//what is condition, why?


Console.WriteLine("Enter your age");
string input = Console.ReadLine();
int age = int.Parse(input);

// Drink Problem

if (age < 16)
{
    Console.WriteLine("I can not give you a drink");
}
else if (age >= 16 && age < 18)
{
    Console.WriteLine("I can give you drink but dont tell police.");
}
else if (age >= 18 && age < 35)
{
    Console.WriteLine("For you buy 1 get 1 free!");
}
else
{
    Console.WriteLine("Enjoy your drink");
}

switch (age)
{
    case 1:
        Console.WriteLine("you are age 1");
        break;
    case 2:
        Console.WriteLine("You are age 2");
        break;
}

//tertinary operator
// <condition> ? <condition true> : <condition false>
int a = 2 > 3 ? 0 : 1;

int b;
if (2 > 3)
{
    b = 0;
}
else
{
    b = 1;
}

Console.WriteLine(a);
Console.WriteLine(b);