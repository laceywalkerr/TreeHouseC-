// Variables are names for values that can vary.
// Y = X + 5
// In this equation, if we set X = 1, then Y would = 6
// If we set X = 10, then Y would = 15, ect

// Variables work in the same way, but instead of strictly numbers, it can be in the form of text, a calender date, or baisically any other piece of data that can be stored.
// When you assign a value to a variable, you're giving that value a name
// ***So, please remember the importance of naming conventions, as well as camelCase.***

class Program
{
    static void Main(string[] args)
    {
        var number = 4;
        var greeting = "hello";
        System.Console.WriteLine(number);
        System.Console.WriteLine(greeting);
        System.Console.WriteLine(number + 2);
        System.Console.WriteLine(12 - number);
    }
}

// The terminal will print out:
//4                                                                                                               
//hello                                                                                                           
//6                                                                                                               
//8