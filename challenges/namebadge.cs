using System;

public class NameBadge
{
    static public void Main()
    {
        string name;
        string jobTitle;
        string company;
        Console.Clear();
        Console.WriteLine("To start creating a name badge, please enter your name.");
        name = Console.ReadLine();
        Console.WriteLine("Next, please enter your job title.");
        jobTitle = Console.ReadLine();
        Console.WriteLine("Lastly, please enter in the name of the company you work for.");
        company = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("|************************************|");
        Console.WriteLine("|Name: {0,30}|", name);
        Console.WriteLine("|{0,36}|", jobTitle);
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|{0,36}|", company);
        Console.WriteLine("|************************************|");
    }
}