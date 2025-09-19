using System;

namespace Tund4;

public class Kass : Loom
{
    public Kass(string nimi, int vanus) : base("Kass", nimi, vanus) { }

    public override void midaTeeb()
    {
        Console.WriteLine($"{Liik} {Nimi} mjäugub ja magab");
    }
}
