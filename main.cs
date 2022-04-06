using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int fahrenheit;
        int celsuis;

        Console.WriteLine("Please enter the fahrenheit");
        Console.WriteLine("");

        Console.Write("fahrenheit: ");
        fahrenheit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        celsuis = ( fahrenheit - 32 ) * 5/9

        Console.WriteLine("celsuis: " + celsuis + "°");

        Console.WriteLine("\nDone.");
    }
}