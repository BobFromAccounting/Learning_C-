using System;
using System.IO;

class FileTotal
{
    static void Main()
    {
        string filename = "prices.txt";
        if (!File.Exists(filename)) return;

        float total = 0;
        foreach (string p in File.ReadLines(filename))
        {
            float price;
            if (float.TryParse(p, out price))
                total += price;
        }
        Console.Clear();
        Console.WriteLine("Total of all prices in file is: " + total);
    }
}