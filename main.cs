using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int fahrenheit;
        int celsius;

        Console.WriteLine("Please enter the fahrenheit");
        Console.WriteLine("");

        Console.Write("fahrenheit: ");
        fahrenheit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        celsius = ( fahrenheit - 32 ) * 5/9;

        Console.WriteLine("celsius: " + celsius + "°");

        Console.WriteLine("\nDone.");
    }
}