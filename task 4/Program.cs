using System;

class Program
{
    static void Main(string[] args)
    {
        // creating Car object
        Car c = new Car();
        c.Display();
        c.StartEngine();
        c.StopEngine();

        Console.WriteLine();

        // creating Bike object
        Bike b = new Bike();
        b.Display();
        b.StartEngine();
        b.StopEngine();
    }
}

// abstract class
abstract class Vehicle
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Display()
    {
        Console.WriteLine("This is a vehicle");
    }
}

// Car class
class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine stopped");
    }
}

// Bike class
class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine stopped");
    }
}