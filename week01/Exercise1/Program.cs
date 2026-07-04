using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is yor last name? ");
        string lastName = Console.ReadLine();

        Console.Write($"Your name is {lastName}, {name} {lastName}.");
    }
}