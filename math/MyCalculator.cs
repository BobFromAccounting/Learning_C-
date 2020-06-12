using System;

public class MyCalculator
{
    static public void Main()
    {
        // C = 2*PI*R
        string radius;
        Console.Clear();
        Console.WriteLine("Please enter the radius: ");
        radius = Console.ReadLine();

        float rad = Convert.ToSingle(radius);
        float pi = 22/7;
        float c = 2 * pi * rad;
        Console.WriteLine("The circumference is {0}", c);

        string number1;
        string number2;
        Console.Clear();
        Console.WriteLine("Please enter first value: ");
        number1 = Console.ReadLine();
        Console.WriteLine("Please enter second value: ");
        number2 = Console.ReadLine();

        Console.WriteLine("The total from the addition of {0} and {1} is {2}.", Convert.ToInt32(number1),
                                                                                Convert.ToInt32(number2),
                                                                                Convert.ToInt32(number1)+Convert.ToInt32(number2));
    }
}