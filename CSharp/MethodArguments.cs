// A parameter is a special variable that you declare at the start of a method.
// It 's just like declaring a variable; you specify a type and a name for the parameter.
// You can specify multiple parameters by separating them with commas.

// Within the method body, you can access the parameter just like you would a variable.
// In the Add method, we print the value of the first parameter, and then print the value of the second parameter.
// Then we print the result of adding first and second together.

// When a method takes parameters, you need to provide argument values when calling that method.
// C# sets each parameter variable with the value in the argument.
// https://teamtreehouse.com/library/method-arguments-5#notes

using System;

class Program
{
    static void Add(double first, double second)
    {
        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(first + second);
    }
    // This would print out in order: the first parameter, the second parameter, and then lastly the result of adding the first and second parameter together.

    static void Subtract(double first, double second)
    {
        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(first - second);
    }

    // When a method takes parameters, you need to provide argument values when calling that method.    
    static void Main(string[] args)
    {
        Add(3, 5);
        // This first argument to Add is going to be the value that is the first parameter.
        // Lets try adding another column with different arguments.
        Add(10.05, 7.2);
        Subtract(9, 3);
        Subtract(21.3, 7.1);

        Wait(3000);
    }

    static void Wait(int delay)
    {
        Console.WriteLine("Waiting...");
        Thread.Sleep(delay);
        Console.WriteLine("Done");
    }
}