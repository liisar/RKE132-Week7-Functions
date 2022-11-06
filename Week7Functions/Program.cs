
Console.WriteLine("Are you arriving or leaving? (in/out)");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}




static void PrintHello() //function / method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodbye() //function / method
{
    Console.WriteLine("See you later!");
}
