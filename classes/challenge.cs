using System;

class WordOrder
{
    static public void Main()
    {
        string word1 = "apple";
        string word2 = "orange";
        int order = String.Compare(word1, word2);
        if (order < 0)
        {
            Console.WriteLine("{0} comes before {1}", word1, word2);
        }
        else if (order > 0)
        {
            Console.WriteLine("{0} comes before {1}", word2, word1);
        }
        else
        {
            Console.WriteLine("Both words are the same!");
        }
    }
}