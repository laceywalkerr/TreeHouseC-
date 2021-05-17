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

// You can also assign them directly, works the same.

class Program3
{
    static void Main(string[] args)
    {
        System.Int32 number = 10;
        System.String greeting = "What's up?";
        System.Console.WriteLine(nunber);
        System.Console.WriteLine(greeting);
        System.Console.WriteLine(number + 2);
    }
}

// you can also use a GetType here.
class Program3
{
    static void Main(string[] args)
    {
        System.Int32 number = 10;
        System.String greeting = "What's up?";
        System.Console.WriteLine(nunber.GetType()); //<-----
        System.Console.WriteLine(greeting.GetType()); //<-----
        System.Console.WriteLine(number + 2);
    }
}

// The console would return:
// System.Int32
// System.String
// What's up?
// 12

// Here are some shortcuts!
// int = System.Int32
// string = System.String

class Program3
{
    static void Main(string[] args)
    {
        int number = 10; //<----
        string greeting = "What's up?"; //<---- See? This works great, too.
        System.Console.WriteLine(nunber.GetType());
        System.Console.WriteLine(greeting.GetType());
        System.Console.WriteLine(number + 2);
    }
}

// Here's a program that uses variable declarations with explocit types for the same integer, floating point number, Boolean value, string and character value that we saw earlier. 
class Program4
{
    static void Main(string[] args)
    {
        System.Int32 wholeNumber = 4;
        System.Double pi = 3.1415;
        System.Boolean status = true;
        System.String greeting = "Hello, world!";
        System.Char oneLetter = 'z';

        System.Console.WriteLine(wholeNumber.GetType());
        System.Console.WriteLine(pi.GetType());
        System.Console.WriteLine(status.GetType());
        System.Console.WriteLine(greeting.GetType());
        System.Console.WriteLine(oneLetter.GetType());
    }
}
// Now, lets apply some shortcuts, since that is what's used usually anyway.

class Program5
{
    static void Main(string[] args)
    {
        int wholeNumber = 4;
        double pi = 3.1415;
        bool status = true;
        string greeting = "Hello, world!";
        char oneLetter = 'z';

        System.Console.WriteLine(wholeNumber.GetType());
        System.Console.WriteLine(pi.GetType());
        System.Console.WriteLine(status.GetType());
        System.Console.WriteLine(greeting.GetType());
        System.Console.WriteLine(oneLetter.GetType());
    }
}