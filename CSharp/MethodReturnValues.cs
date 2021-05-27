using System;
using System.Threading;

class Program
{
    static void Ask(string question)
    {
        Console.WriteLine(question);
        string answer = Console.ReadLine();
        //Console.Readline will return the users responce when the question is prompted, and then gets assigned to the "answer" variable.
        Console.WriteLine(answer);
    }

    static double Add(double first, double second)
    {
        return first + second;
    }

    static double Subtract(double first, double second)
    {
        return first - second;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the cat food store!");
        Ask("How many cans are you ordering?");

        // Just gonna use a console writeline to throw a space between the kind of code I'm calling back, makes it easier to read.
        Console.WriteLine("-----------------");

        double total = Add(3, 5);
        Console.WriteLine(total);
        double remaining = Subtract(21.3, 7.1);
        Console.WriteLine(remaining);

        Console.WriteLine("----You could also do this and return the same info-----");

        Console.WriteLine(Add(3, 5));
        Console.WriteLine(Subtract(21.3, 7.1));

    }
}