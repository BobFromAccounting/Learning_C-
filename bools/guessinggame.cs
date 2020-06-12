using System;

public class GuessMyNumber
{
    static public void Main()
    {
        int number = 90;
        int guess;

        Console.Clear();
        Console.WriteLine("What number am I thinking of?");
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess < number)
        {
            Console.WriteLine("Your guess is too low.");
        }
        else if (guess > number)
        {
            Console.WriteLine("Your guess is too high.");
        }
        else
        {
            Console.WriteLine("Congratulations.");
        }
    }
}