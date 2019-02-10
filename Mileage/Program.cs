using System;

namespace Mileage
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("How many miles have you driven? ");

            // Get input from the user and save it to a variable.
            float miles = float.Parse(Console.ReadLine());

            Console.Write("How many gallons of gas have you consumed? ");
            // Get input from the user and save it to a second variable.
            float gallons = float.Parse(Console.ReadLine());

            // Output - Your miles per gallon is (computed value)
            Console.WriteLine("Your miles per gallon is " + miles / gallons);
            Console.ReadLine();
        }
    }
}
