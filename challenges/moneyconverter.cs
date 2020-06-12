using System;

public class MoneyConverterSimple
{
    static public void Main()
    {
        string convRate;
        string convAmt;

        Console.Clear();
        Console.WriteLine("Enter Unit/USD rate: ");
        convRate = Console.ReadLine();
        Console.WriteLine("Enter amount to be converted: ");
        convAmt = Console.ReadLine();
        float convTotal = Convert.ToSingle(convRate) * Convert.ToSingle(convAmt);

        Console.WriteLine("You will receive: ${0}", convTotal);
    }
}