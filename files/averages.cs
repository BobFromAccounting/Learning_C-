using System;
using System.IO;

class FileAverages
{
    static public void Main()
    {
        string filename = "prices.txt";
        if (!File.Exists(filename)) return;

        float total = 0;
        int count = 0;
        foreach (string p in File.ReadLines(filename))
        {
            float price;
            if (float.TryParse(p, out price))
            {
                total += price;
                count++;
            }
        }
        Console.Clear();
        Console.WriteLine("The average of all prices is {0:0.00}", total / count);
    }
}