using System;
using System.IO;

class CarLogging
{
    static void Main()
    {
        string filename = "cars.txt";
        CarDetails c1 = new CarDetails("Honda", "Civic", 2006, "red", "345RGT");
        Console.Clear();
        c1.PrintDetails(filename);
    }
}