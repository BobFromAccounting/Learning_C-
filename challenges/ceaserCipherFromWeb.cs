using System;
using System.Net;

public class CaesarCipherAdvanced
{
    static public void Main () 
    {
        Console.Clear();
        string url = "http://www.textfiles.com/fun/blood";
        WebClient wc = new WebClient();
        string webText = wc.DownloadString(url);

        foreach(char c in webText)
        {
            if(c == ' ')
            {
                Console.Write(" ");
            }
            else
            {
                char letter = c;
                if(letter > ('V') && letter <= 'Z')
                {
                    letter = (char)(letter-26);
                }
                else if(letter > ('v') && letter <= 'z') 
                {
                    letter = (char)(letter-26);
                }

                Console.Write("{0}",(char)(letter + 5));
            }
        }
        Console.Write("\n");
    }
}