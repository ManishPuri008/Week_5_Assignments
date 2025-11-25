using System;

class Program
{
    static void Main()
    {
        // creating a Car object
        Car car = new Car();
        car.Brand = "Toyota";
        car.Speed = 120;
        car.Seats = 5;

        // calling base class methods
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        // creating a Motorcycle object
        Motorcycle bike = new Motorcycle();
        bike.Brand = "Yamaha";
        bike.Speed = 90;
        bike.Type = "Sport";

        // calling base class methods
        bike.Start();
        bike.DisplayInfo();
        bike.Stop();
    }
}

// base class
class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle stopped");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Speed: " + Speed);
    }
}

// derived class 1
class Car : Vehicle
{
    public int Seats { get; set; }   // unique field

    public override void DisplayInfo()
    {
        base.DisplayInfo();          // using base class code
        Console.WriteLine("Seats: " + Seats);
    }
}

// derived class 2
class Motorcycle : Vehicle
{
    public string Type { get; set; }   // unique field

    public override void DisplayInfo()
    {
        base.DisplayInfo();            // using base class code
        Console.WriteLine("Type: " + Type);
    }
}