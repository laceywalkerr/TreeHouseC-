// If you declare a variable within a method, it's only accessible within that method. But trust us, that's a good thing! (- TeamTreeHouse)
// Variable declared within a method is accessible only within that method
// Can declare multiple variables with same name in different scopes

// A variable scope is the portion of the program code that that variable is visable within.

using System;

class Program
{
    static void MyMethod()
    {
        // This "total" variable is completely separate from the "total" variable in the Main method!
        int total = 0;
        total += 1;
        Console.WriteLine("total in MyMethod:");
        Console.WriteLine(total);
    }

    static void Main(string[] args)
    {
        int total = 0;
        total += 10;
        MyMethod();
        Console.WriteLine("total in Main:");
        Console.WriteLine(total);
    }
}