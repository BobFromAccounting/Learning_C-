using System;

public class SimpleCalculator
{
    static public void Main()
    {
        float number1;
        float number2;
        string op;

        Console.Clear();
        Console.WriteLine("Enter Number 1");
        number1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter number 2.");
        number2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Operator");
        op = Console.ReadLine();


        switch (op)
        {
            case "*":
                Console.WriteLine("{0}", number1 * number2);
                break;
            case "/":
                Console.WriteLine("{0}", number1 / number2);
                break;
            case "+":
                Console.WriteLine("{0}", number1 + number2);
                break;
            case "-":
                Console.WriteLine("{0}", number1 - number2);
                break;
            default:
                Console.WriteLine("Cannot do calculation.");
                break;
        }
    }
}