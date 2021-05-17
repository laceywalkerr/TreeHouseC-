// Values in C# are classified into different Types that specify what the Values can be used for.
// You can view a type of value by calling the GetType method on it.
// (A method is a collection of code, which you can call in order for it to do something. )
// Method call example: .GetType()
// For whole numbers, use .Int32()
// For strings of text surrounded by double quotes, use .GetType()

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(1. GetType()); // Prints "System.Int32"
        System.Console.WriteLine(2. GetType()); // Prints "System.Int32"
        System.Console.WriteLine(3. GetType()); // Prints "System.Int32"
        System.Console.WriteLine("hello".GetType()); // Prints "System.String"
        System.Console.WriteLine("hi".GetType()); // Prints "System.String"
        System.Console.WriteLine(4. GetType()); // Prints "System.Int32"
        System.Console.WriteLine(3.1415.GetType()); // Prints "System.Double"
        System.Console.WriteLine(true.GetType()); // Prints "System.Boolean"
        System.Console.WriteLine("hello".GetType()); // Prints "System.String"
        System.Console.WriteLine('z'.GetType()); // Prints "System.Char"
    }
}

// How to declare a variable without assining an innitial value?
// You give it an explicit type. (You specify what type of value the variable should hold.)
// Juat write the type name followed by the variable name and the variable is declared.
// You can then assign the value to the variable later on.

class Program2
{
    static void Main(string[] args)
    {
        System.Int32 number;
        System.String greeting;
        number = 10;
        greeting = "What's up?";
        System.Console.WriteLine(nunber);
        System.Console.WriteLine(greeting);
        System.Console.WriteLine(number + 2);
    }
}