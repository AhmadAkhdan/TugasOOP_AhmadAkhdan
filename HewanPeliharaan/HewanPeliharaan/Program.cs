using System;
using System.Collections.Generic;

// Class & Object + Constructor + Encapsulation
class Hewan
{
    private string nama; // data hiding

    public Hewan(string nama) // constructor
    {
        this.nama = nama;
    }

    public string Nama // encapsulation
    {
        get { return nama; }
        set { nama = value; }
    }

    // Polymorphism (akan dioverride)
    public virtual void Suara()
    {
        Console.WriteLine($"{nama} mengeluarkan suara...");
    }
}

// Inheritance
class Kucing : Hewan
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

// Composition
class Pemilik
{
    public string Nama { get; set; }
    private List<Hewan> peliharaan;

    public Pemilik(string nama)
    {
        Nama = nama;
        peliharaan = new List<Hewan>();
    }

    public void TambahPeliharaan(Hewan h)
    {
        peliharaan.Add(h);
    }

    public void TampilkanPeliharaan()
    {
        Console.WriteLine($"{Nama} memiliki hewan:");
        foreach (var h in peliharaan)
        {
            Console.Write("- ");
            h.Suara();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Object
        Kucing k1 = new Kucing("Kitty");
        Kucing k2 = new Kucing("Milo");

        // Overloading
        k1.Suara();
        k1.Suara("senang");

        // Composition
        Pemilik p = new Pemilik("Ahmad");
        p.TambahPeliharaan(k1);
        p.TambahPeliharaan(k2);

        p.TampilkanPeliharaan();

        Console.ReadLine();
    }
}
