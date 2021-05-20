//List of CatFood Store Features
// X- Display welcome message -X
// Ask for quality
// Calculate Total
// Discount for large orders

using System;
using System.Threading;

class Program
{
    static void Main(string[] args) //<---- This is our method
    {
        Console.WriteLine("Welcome to the catfood store!");
        System.Threading.Thread.Sleep(3000); // <--- This method makes it wait for 3 seconds before loading anything else to the console.
        Console.WriteLine("done sleeping.");
    }
}

//Code we started with:
class Program
{
    static void Main(string[] args)
    {

    }
}

// Notes:
// A method is a group of code statements that are put together to perform a particular task
// "Writeline" for example, is a method. The task it carries out is to write a line of text out to the console.
// A method, like a function, is a set of instructions that perform a task. The difference is that a method is associated with an object, while a function is not. (Source: Codecademy.com)