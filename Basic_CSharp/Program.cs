// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello World!");

int a1 = 10;
int a2 = 5;
//String interpolation
string s1 = $"{a1} and {a2} sum is ";
string s2 = "Darshan";

Console.WriteLine(s1.Length);
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());

Console.WriteLine(s1 + (a1 + a2));
Console.WriteLine(string.Concat(s1, s2));

//String access
string s3 = "DarshanPatel";
Console.WriteLine(s3[3]);
Console.WriteLine(s3.IndexOf('h'));
Console.WriteLine(s3.Substring(4, 4));

//Escape caharacters -> \, \n, \t

string s4 = "my name is \"xyz\". \nI am C#Developer.";
Console.WriteLine(s4);

