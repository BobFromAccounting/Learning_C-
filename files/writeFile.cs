using System;
using System.IO;

class FileWriting
{
    static void Main()
    {
        string userInput;
        Console.Clear();
        Console.Write("Enter your name: ");
        userInput = Console.ReadLine();

        File.AppendAllText("details.txt", userInput + '\n');
    }
}