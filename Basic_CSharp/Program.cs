// See https://aka.ms/new-console-template for more information

//------------------------------------Loops
//-------------------------- while

int a = 0;
while (a > 0)
{
    Console.WriteLine("a : " + a);
}

//====================== do while
int b = 0;
do
{
    Console.WriteLine("b : " + b);
}
while (b > 0);

//--------------- for
// first -> initialize
// second -> condition
// third -> updates

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 2 * i; j++)
    {
        // its even number.
        if (j % 2 == 0)
        {
            Console.Write(j + " ");
        }
    }
    Console.WriteLine();
}


//------------------ Guessing Game -------------------
int secretNum = 10;
Console.WriteLine("Guess My Secret Number : ");

while (true)
{
    int n = int.Parse(Console.ReadLine());

    if (n == secretNum)
    {
        Console.WriteLine("You Win!");
        break;
    }
    else if (n > secretNum)
    {
        Console.WriteLine("You number is bigger than my Secret number.");
        Console.WriteLine("Guess Again");
    }
    else
    {
        Console.WriteLine("You number is smaller than my Secret number.");
        Console.WriteLine("Guess Again");
    }
}