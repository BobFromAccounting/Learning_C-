using System;

public class Variables
{
    static public void Ints()
    {
        int number = 5;
        int aVal = 7;
        Console.WriteLine("My number is {0} {1} = {2}", number, aVal, (number + aVal));
    }

    static public void Floats()
    {
        float myFloat = 123.245f;
        Console.WriteLine("My float is {0}", myFloat);
    }

    static public void Chars()
    {
        char myCharacter = 'A';
        Console.WriteLine("My char is {0}", myCharacter); 
    }

    static public void StringExplorer()
    {
        string name;
        string age;
        Console.Clear();
        Console.WriteLine("Hello, what is your name?");
        name = Console.ReadLine();
        Console.WriteLine("Hello {0}, how old are you?", name);
        age = Console.ReadLine();
        Console.WriteLine("Good to know you are {1}.", name, age);
    }

    static public void Main()
    {
        Variables.Ints();
        Variables.Floats();
        Variables.Chars();
        Variables.StringExplorer();
    }
}