using System;

class Program
{
    static void Main(string[] args)
    {
        // creating store
        ElectronicsStore store = new ElectronicsStore();

        // creating laptop and smartphone
        Laptop l = new Laptop("Dell", 1200);
        Smartphone s = new Smartphone("Samsung", 800);

        // adding them
        store.device1 = l;
        store.device2 = s;

        // showing details
        store.ShowAllDeviceDetails();
    }
}

// abstract class
abstract class ElectronicDevice
{
    private string brand;
    private double price;

    public ElectronicDevice(string b, double p)
    {
        brand = b;
        price = p;
    }

    public string Brand
    {
        get { return brand; }
    }

    public double Price
    {
        get { return price; }
    }

    public abstract void ShowInfo();
}

// Laptop class
class Laptop : ElectronicDevice
{
    public Laptop(string b, double p) : base(b, p) { }

    public void TurnOnBattery()
    {
        Console.WriteLine("Laptop battery on");
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Laptop Brand: " + Brand);
        Console.WriteLine("Laptop Price: " + Price);
    }
}

// Smartphone class
class Smartphone : ElectronicDevice
{
    public Smartphone(string b, double p) : base(b, p) { }

    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera enabled");
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Smartphone Brand: " + Brand);
        Console.WriteLine("Smartphone Price: " + Price);
    }
}

// BASIC store class (no lists, no loops)
class ElectronicsStore
{
    public ElectronicDevice device1;
    public ElectronicDevice device2;

    public void ShowAllDeviceDetails()
    {
        if (device1 != null)
        {
            device1.ShowInfo();
        }

        if (device2 != null)
        {
            device2.ShowInfo();
        }
    }
}