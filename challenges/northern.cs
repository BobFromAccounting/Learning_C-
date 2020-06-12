using System;

public class ContinueStatement
{
    static public void Main()
    {
        string fileContents = Console.In.ReadToEnd();
        Console.Clear();

        string[] lines = fileContents.Split('\n');

        foreach (string l in lines)
        {
            if (l.IndexOf("NULL") >=0 || l == lines[0])
            {
                // Console.WriteLine("Error: {0}", l);
                continue;
            }

            // Find Capitals from the southern hemisphere where latitude is a negative number.
            string[] fields = l.Split(',');
            float lat = Convert.ToSingle(fields[2]);
            if (lat > 0)
            {
                Console.WriteLine("{0}", fields[1]);
            }
        }
        // Console.WriteLine("{0}", lines[5]);
        // Console.WriteLine(fileContents);

    }
}