using System;

// Inheritance
public class Kucing : Hewan
{
    public Kucing(string nama) : base(nama) { }

    // Polymorphism - Overriding
    public override void Suara()
    {
        Console.WriteLine($"{Nama} berkata: Meong!");
    }

    // Polymorphism - Overloading
    public void Suara(string mood)
    {
        Console.WriteLine($"{Nama} berkata dengan {mood}: Meooong!");
    }
}
