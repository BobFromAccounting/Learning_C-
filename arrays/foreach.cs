using System;

public class ScoreProcessing
{
    static public void Main()
    {
        int[] scores = { 3, 5, 6, 8, 3, 1, 2, 5, 3, 1, 4, 8, 9, 3, 5, 7, 9, 1, 2, 3, 5 };
        // initialize array with 25 entries set to 0: int[] scores = new int[25];

        Console.WriteLine("Processing......");

        foreach(int box in scores)
        {
            Console.WriteLine("{0}", box / 25.0f * 100); 
        }
    }
}