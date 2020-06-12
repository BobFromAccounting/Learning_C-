using System;

public class ForLoop
{
    static public void Main()
    {
        int total = 0;
        float numberOfStudents;

        Console.Clear();
        Console.WriteLine("Please enter the number of students: ");
        numberOfStudents = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Please enter each grade to be averaged: ");
        for (int i = 1; i <= numberOfStudents; i++)
        {
            Console.WriteLine("Enter value {0}", i);
            total = total + Convert.ToInt32(Console.ReadLine());
        }
        
        float avg = total / (float) 10.0f;
        Console.WriteLine("The average grade is {0}", avg);
    }
}