using System;

class Program
{
    static void Main(string[] args)
    {
        //Displays "Hello World" on the terminal.
        System.Console.Writeline("Hello Lacey!"); //<-- lets delete this semi colon from the code we made earlier in CSharpProgram.cs
    }
}

// What would happen, is there would be a compiling error. The code couldnt run properly.
// in most cases, it VS will tell you "; expected", as well as that is it is in CompileErrors.cs as well as the line and column number within the code where the error is detected. (8,49)
// Sometimes, you will also be given error codes. Feel free to copy the error code and do a quick google on it!
// A similar error will throw if you are missing a curly brace where one is expected. "} expected."