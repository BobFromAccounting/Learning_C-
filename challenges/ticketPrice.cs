using System;

public class TicketPrices
{
    static public void Main()
    {
        string name;
        int dob;
        float price;

        Console.Clear();
        Console.WriteLine("Please enter customer name: ");
        name = Console.ReadLine();
        Console.WriteLine("Please enter the customers DOB: ");
        dob = Convert.ToInt32(Console.ReadLine());

        if (dob < 1950 || dob > 2000)
        {
            price = 5.30f;
        }
        else {
            price = 25.00f;
        }

        Console.WriteLine("|********************|");
        Console.WriteLine("|   -- ADMIT ONE --  |");
        Console.WriteLine("|Name: {0, 14}|", name);
        Console.WriteLine("|Price: ${0,12:0.00}|", price);
        Console.WriteLine("|--------------------|");
    }
}