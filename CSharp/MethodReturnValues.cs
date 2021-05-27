using System;
using System.Threading;

class Program
{
    static void Ask(string question)
    {
        Console.WriteLine(question);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the cat food store!");
        Ask("How many cans are you ordering?");
    }
}