using System;

class Laptop
{
    public string Merk { get; set; }
    public string Tipe { get; set; }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }

    public virtual void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }

    public virtual void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }

    internal void TampilkanSpesifikasi1()
    {
        throw new NotImplementedException();
    }
}

class Vivobook : Laptop
{
    public string Vga { get; set; }
    public string Processor { get; set; }
}

class IdeaPad : Laptop
{
    public string Vga { get; set; }
    public string Processor { get; set; }
}

class Predator : Laptop
{
    public string Vga { get; set; }
    public string Processor { get; set; }

    public override void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game di mode Predator");
    }
}

class Program
{
    static void Main()
    {
        Laptop laptop1 = new Vivobook
        {
            Merk = "ASUS",
            Tipe = "Vivobook",
            Vga = "Nvidia",
            Processor = "Core i5"
        };

        Laptop laptop2 = new IdeaPad
        {
            Merk = "Lenovo",
            Tipe = "IdeaPad",
            Vga = "AMD",
            Processor = "Ryzen"
        };

        Predator predator = new Predator
        {
            Merk = "Acer",
            Tipe = "Predator",
            Vga = "AMD",
            Processor = "Core i7"
        };

        laptop1.LaptopDinyalakan();
        laptop1.BermainGame();

        laptop2.LaptopDinyalakan();
        laptop2.Ngoding();

        predator.LaptopDinyalakan();
        predator.BermainGame();

        laptop1.LaptopDimatikan();
        laptop2.LaptopDimatikan();
        predator.LaptopDimatikan();

    }
}
