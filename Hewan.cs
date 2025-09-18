using System;

public class Hewan
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
