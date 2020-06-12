using System;

public class Person
{
    string name = "";
    string address = "";
    string phone = "";
    float height = 0;

    public Person()
    {
        name = "Joe Bloggs";
        address = "12 Smith Street";
        phone = "12108675309";
        height = 180;
    }

    public Person(string n, string a, string ph, float h)
    {
        name = n;
        address = a;
        phone = ph;
        height = h;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Name: " + name + "\n" +
                          "Address: " + address + "\n" +
                          "Phone: " + phone + "\n" +
                          "Height: " + height);
    }
}

public class MyContacts
{
    static public void Main()
    {
        Person friend = new Person();
        Person friend2 = new Person("Tarek", "123 My Address St", "12103334455", 198);
        Person friend3 = new Person("Shirley", "456 My Address St", "12103336677", 145);
        Person friend4 = new Person("Franni", "789 My Address St", "12103345678", 162);
        Console.Clear();
        friend.PrintDetails();
        friend2.PrintDetails();
        friend3.PrintDetails();
        friend4.PrintDetails();
    }
}