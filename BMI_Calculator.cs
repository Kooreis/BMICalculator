using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter weight in Kilograms: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in Meters: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / Math.Pow(height, 2);

        Console.WriteLine("Your BMI is " + Math.Round(bmi, 2));

        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight.");
        }
        else if (bmi < 24.9)
        {
            Console.WriteLine("You are normal weight.");
        }
        else if (bmi < 29.9)
        {
            Console.WriteLine("You are overweight.");
        }
        else
        {
            Console.WriteLine("You are obese.");
        }
    }
}