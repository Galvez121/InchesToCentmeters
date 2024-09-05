using System;

class Program
{
    public static void Main(string[] args)
    {
        // Module 2 Exercise 2.1 
      
        const double AmountOfCentimeters = 2.54;
        int inches = 5;
        double convertion_in_centimeters = inches * AmountOfCentimeters;

        Console.WriteLine($"{convertion_in_centimeters} centimeters"); 
    }
}