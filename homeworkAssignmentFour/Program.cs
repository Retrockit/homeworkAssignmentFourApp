// We are building a console app that will ask the user for their name and their age. if their name is Bob or Sue
// address them as Professor. If the person is under 21, recommend they wait X years before starting this class.

Console.WriteLine("What is your name?");

string name = Console.ReadLine();

Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());

if ((name == "Bob" || name == "Sue") && age >= 21)
{
    Console.WriteLine("Hello Professor " + name);
}

else if (age < 21)
{
    int years = 21 - age;
    Console.WriteLine($"Hello {name}, you should wait {years} years before starting this class.");
}