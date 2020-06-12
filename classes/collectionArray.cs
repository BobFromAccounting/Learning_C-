using System;

class CarCollection
{
    static void Main()
    {
        CarDetails[] myCars = new CarDetails[10];
        string make;
        string model;
        int year;
        string registration;
        string colour;

        for (int i = 0; i < myCars.Length; i++)
        {
            Console.WriteLine("Enter details for car {0}: ", i + 1);
            Console.Write("Make: ");
            make = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Registration: ");
            registration = Console.ReadLine();
            Console.Write("Colour: ");
            colour = Console.ReadLine();

            myCars[i] = new CarDetails(make, model, year, colour, registration);
        }

        Console.Clear();

        for (int i = 0; i < myCars.Length; i++)
        {
            myCars[i].PrintDetails();
        }
    }
}