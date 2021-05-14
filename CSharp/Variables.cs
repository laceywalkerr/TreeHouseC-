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

// If you want to change the meaning of a variable, that's fine. but it can only be declared once. for example:
class Program
{
    static void Main(string[] args)
    {
        var number = 4;
        var greeting = "hello";
        System.Console.WriteLine(number);
        System.Console.WriteLine(greeting);
        System.Console.WriteLine(number + 2);
        number = 10; // <--
        System.Console.WriteLine(12 - number);
    }
}

// we can asign the variable a new meaning, but we only use var once.
// You can only delcare one variable at a time with the same name n the same scope.
// If you use var again for the same variable, the program will treat it as a different variable within the program, but with the same name.
// This would give an error. "CS0219: The variable 'number' is assigned, but it's value is never used"
// You would need to remove "var" so it can be treated as an assignment, not a declaration.
// Remeber that you can only declare a variable once, but that you can assign it as many times as you need.