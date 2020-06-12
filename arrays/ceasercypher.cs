using System;

public class CaeserCipher
{
    static public void Main()
    {
        string plaintext;
        Console.Clear();
        Console.WriteLine("Enter your text:");
        plaintext = Console.ReadLine();
        
        foreach(char c in plaintext)
        {
            if (c == ' ')
            {
                Console.Write(" ");
            }
            else
            {
                char letter = c;
                if (letter >= 'X' && letter <= 'Z')
                {
                    letter = (char)(letter - 26);
                }
                if (letter >= 'x' && letter <= 'z')
                {
                    letter = (char)(letter - 26);
                }
                Console.Write("{0}", (char)(letter + 3));
            }
        }
        Console.WriteLine("");
    }
}