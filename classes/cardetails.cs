using System;
using System.IO;

class CarDetails
{
    string make;
    string model;
    int year;
    string registration;
    string colour;

    public CarDetails(string m, string mod, int yr, string col, string reg)
    {
        make = m;
        model = mod;
        year = yr;
        colour = col;
        registration = reg;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Make: " + make);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Colour: " + colour);
        Console.WriteLine("Registration Number: " + registration);
        Console.WriteLine("=========================");
    }

    public void PrintDetails(string filename)
    {
        File.AppendAllText(filename, "Make: " + make + '\n');
        File.AppendAllText(filename, "Model: " + model + '\n');
        File.AppendAllText(filename, "Year: " + year + '\n');
        File.AppendAllText(filename, "Colour: " + colour + '\n');
        File.AppendAllText(filename, "Registration Number: " + registration + '\n');
        File.AppendAllText(filename, "=========================" + '\n');
    }
}