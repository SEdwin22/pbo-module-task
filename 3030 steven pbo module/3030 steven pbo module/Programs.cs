using System;

class Laptopa1
{
    public string Merk1 { get; set; }
    public string Tipe1 { get; set; }

    public virtual void TampilkanSpesifikasi()
    {
        Console.WriteLine($"Spesifikasi Laptop:\nMerk: {Merk1}\nTipe: {Tipe1}");
    }

    internal void TampilkanSpesifikasi1()
    {
        throw new NotImplementedException();
    }

    internal void TampilkanSpek()
    {
        throw new NotImplementedException();
    }

    internal void TampilSpek()
    {
        throw new NotImplementedException();
    }
}

class Vivobook1 : Laptopa1
{
    public string Vga1 { get; set; }
    public string Processor1 { get; set; }

    public override void TampilSpek()
    {
        base.TampilSpek();
        Console.WriteLine($"VGA: {Vga1}\nProcessor: {Processor1}");
    }
}
class Program1
{
    private static object Laptopa1;

    static void Main(string[] args) => _ = _ = Laptopa1.TampilSpek();
}
