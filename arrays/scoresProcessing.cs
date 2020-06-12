using System;

public class ScoreProcessing
{
    static public void Main()
    {
        int[] scores = { 3, 5, 6, 8, 3, 1, 2, 5, 3, 1, 4, 8, 9, 3, 5, 7, 9, 1, 2, 3, 5 };
        // initialize array with 25 entries set to 0: int[] scores = new int[25];

        for (int i = 0; i < 25; i++)
        {
            Console.WriteLine("{0}", scores[i]/25.0f * 100);
        }

        // int[] grades = { 3, 5, 6, 8, 3, 1, 2, 5, 3, 1, 4, 8, 9, 3, 5, 7, 9, 1, 2, 3, 5, 3, 5, 6, 8, 3 };

        // for (int i = 0; i < grades.Length; i++)
        // {
        //     Console.WriteLine("{0}", grades[i]/25.0f * 100);
        // }

        int[] userScores;
        int numScores;

        Console.Clear();
        Console.WriteLine("How many scores?");
        numScores = Convert.ToInt32(Console.ReadLine());

        userScores = new int[numScores];

        for (int i = 0; i < userScores.Length; i++)
        {
            Console.WriteLine("Enter score number {0}", i);
            userScores[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Processing......");

        for (int i = 0; i < userScores.Length; i++)
        {
            Console.WriteLine("{0}", userScores[i]/25.0f * 100);
        }
    }
}