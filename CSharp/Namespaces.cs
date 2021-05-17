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