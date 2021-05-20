// Namespaces are groupings of similar classes.
class Program
{
    static void Main(string[] args)
    {
        // Create a new random number generator.
        System.Random generator = new System.Random();
        // Generate a floating-point number between 0 and 1.
        double randomNumber = generator.NextDouble();
        // Round the number to a single decimal place.
        double roundedNumber = System.Math.Round(randomNumber, 1);
        // Print the rounded number.
        System.Console.WriteLine(roundedNumber);
    }
}

// Now if you use the using directive ("using System;") at the start of the program you can remove the namespace in front of the types names.
// EX:
//using System; //<----- Having this here, we dont have to put the "System." in front of the type names. (Honestly I prefer this way, it gets too repetative and IMO unnessicary, but it's important to know these things.)
// Commented it out for now because it was erroring it out.
class Program
{
    static void Main(string[] args)
    {
        // Create a new random number generator.
        Random generator = new Random();
        // Generate a floating-point number between 0 and 1.
        double randomNumber = generator.NextDouble();
        // Round the number to a single decimal place.
        double roundedNumber = Math.Round(randomNumber, 1);
        // Print the rounded number.
        Console.WriteLine(roundedNumber);
    }
}

//Namespaces have the following properties:

//They organize large code projects.
//They're delimited by using the . operator.
//The using directive obviates the requirement to specify the name of the namespace for every class.
//The global namespace is the "root" namespace: global::System will always refer to the .NET System namespace.
// This information was sourced at https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces