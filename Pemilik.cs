using System;
using System.Collections.Generic;

// Composition
public class Pemilik
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
