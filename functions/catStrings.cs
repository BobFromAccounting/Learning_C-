using System;

public class ConcatenateStrings
{
    static public void Main()
    {
        string string1 = "I am a ";
        string string2 = "concatenated string.";

        Console.WriteLine(string.Concat(string1, string2));
    }
}