using System;

public class Maths
{
    static public void Main()
    {
        // F = m(a)
        float force;
        float mass = 3.0f;
        float acceleration = 10.5f;
        force = mass * acceleration;
        Console.WriteLine("Force is equal to {0}", force);

        // F = C * 9/5 + 32
        float f;
        float c = 32;
        f = c * 9/5 + 32;

        Console.WriteLine("{1} Celcius is equal to {0} Fahrenheit", f, c);
    }
}