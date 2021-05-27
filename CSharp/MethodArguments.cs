using System;

class Program
{
    static void Wait()
    {
        Console.WriteLine("Waiting...");
        Thread.Sleep(3000);
        Console.WriteLine("Done");
    }

    static void Main(string[] args)
    {
        Wait();
    }
}