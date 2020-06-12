using System;

public class WhileLoop
{
    static public void Main()
    {
        string input = "";
        while (input != "Quit")
        {
            Console.WriteLine("Enter a value: ");
            input = Console.ReadLine();
        }
        Console.WriteLine("Program Over. Good-bye.");

        int i;
        Console.Clear();
        Console.WriteLine("Enter 1 for options\n" +
                    "      2 to quit \n" +
                    "      3 to start game.");

        do
        {
            Console.WriteLine("Options?");
            i = Convert.ToInt32(Console.ReadLine());
        }
        while (i < 1 || i > 3);
        Console.WriteLine("Thank you!");
    }
}