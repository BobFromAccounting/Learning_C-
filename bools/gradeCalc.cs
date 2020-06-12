using System;

public class GradeCalculator
{
    static public void Main()
    {
        int result;

        Console.Clear();
        Console.WriteLine("What is the final result?");
        result = Convert.ToInt32(Console.ReadLine());

        if (result >= 95)
        {
            Console.WriteLine("A");
        }
        else if (result >= 85)
        {
            Console.WriteLine("B");
        }
        else if (result >= 75)
        {
            Console.WriteLine("C");
        }
        else if (result >= 50)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        Console.WriteLine("Calculation Over.");
    }
}