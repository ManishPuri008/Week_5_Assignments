using System;

class Program
{
    static void Main()
    {
        // creating object of Printer class
        Printer p = new Printer();

        // calling overloaded methods
        p.Print("Hello");
        p.Print(10);
        p.Print("Hello", 3);
    }
}

// Printer class
class Printer
{
    // method 1
    public void Print(string message)
    {
        Console.WriteLine(message);
    }

    // method 2
    public void Print(int number)
    {
        Console.WriteLine(number);
    }

    // method 3 (overloaded)
    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(message);
        }
    }
}