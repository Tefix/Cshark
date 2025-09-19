namespace SõidukiteLiideseRakendamine
{
    
    public class Buss : ISõiduk
    {
        public string Nimi { get; set; }
        public double Kütusekulu { get; set; }
        public double Vahemaa { get; set; }
        public int Reisijad { get; set; }

        public Buss(string nimi, double kütusekulu, double vahemaa, int reisijad)
        {
            Nimi = nimi;
            Kütusekulu = kütusekulu;
            Vahemaa = vahemaa;
            Reisijad = reisijad;
        }

        public double ArvutaKulu()
        {
            if (Reisijad <= 0) return 0;
            return (Kütusekulu * Vahemaa / 100) / Reisijad;
        }

        public double ArvutaVahemaa()
        {
            return Vahemaa;
        }

        public override string ToString()
        {
            return $"Buss: {Nimi}, Vahemaa: {Vahemaa} km, Kulu per reisija: {ArvutaKulu():F2} L";
        }
    }
}
