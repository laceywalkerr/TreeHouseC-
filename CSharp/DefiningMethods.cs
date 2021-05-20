using System;
using System.Threading;

class Program
{
    static void Wait()
    {
        Console.WriteLine("Waiting...");
        Thread.Sleep(3000);
        Console.WriteLine("Done");
    }

    static void CountToThree()
    {
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine(3);
    }

    static void Main(string[] args)
    {
        Wait();
        CountToThree();
    }
}

//static keyword means you can call the method all by itself; it doesn't belong to an object.
//GetType() is an example of a method you can only call on an object.
//Have to place a dot operator after an object, then call the method: 42.GetType();
//On the other hand, Console.WriteLine() is an example of a static method; a method you can call all by itself:
//WriteLine takes arguments in parentheses, but you don't have to refer to an object, add a dot operator, and then call the method.
//void means no return value; we'll talk about return values shortly