using System;

public class LocalVars
{
    static int i = 99;

    static public void Main()
    {
        Console.Clear();
        Console.WriteLine("i before loop {0}", i);

        Counter(out i);

        Console.WriteLine("i after loop {0}", i);
    }

    static void Counter(out int i)
    {
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}