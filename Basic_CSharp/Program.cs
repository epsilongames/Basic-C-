// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello World!");

// Operators
// Arithmatic operator -> +, -, /, *, %, ++, --
// Assignment operator -> =, += , -=, *=, /=
// Comparision operator -> >, < ,>=, <= , ==
// Logical operator -> &&, ||, !

int a = 1;
int b = 2;

//a = a + 1;
//b++;

//a = a - 1;
//b--;

a += 5; // a = a + 5;
b *= 2; // b = b * 2;

bool x = a <= b;

a = 1;
b = 1;

bool y = a == b;

bool and = x && y;
bool or = x || y;
bool not = !and;

Console.WriteLine("X : " + x);
Console.WriteLine("y : " + y);
Console.WriteLine("and : " + and);
Console.WriteLine("or: " + or);
Console.WriteLine("not : " + not);
