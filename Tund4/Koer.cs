using System;

namespace Tund4;

public class Koer : Loom
{
    public Koer(string nimi, int vanus) : base("Koer", nimi, vanus) { }

    public override void midaTeeb()
    {
        Console.WriteLine($"{Liik} {Nimi} haukub ja jookseb");
    }
}
