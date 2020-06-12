using System;

public class CaeserCipher
{
    static public void Main()
    {
        string plaintext;
        int shiftAmount;
        Console.Clear();
        Console.WriteLine("Enter your text:");
        plaintext = Console.ReadLine();
        Console.WriteLine("Enter numerical value to be used to shift letters by: ");
        shiftAmount = Convert.ToInt32(Console.ReadLine());

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
                Console.Write("{0}", (char)(letter + shiftAmount));
            }
        }
        Console.WriteLine("");
    }
}