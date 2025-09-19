using System;
using 

namespace Tund4;

public abstract class Loom
{
    public string Liik;
    public string Nimi;
    public int Vanus;

    public Loom() { }

    public Loom(string liik, string nimi, int vanus)
    {
        Liik = liik;
        Nimi = nimi;
        Vanus = vanus;
    }

    public void Info()
    {
        Console.WriteLine($"{Liik} {Nimi}, {Vanus} aastat vana");
    }

    public abstract void midaTeeb();
}