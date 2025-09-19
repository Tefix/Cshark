namespace SõidukiteLiideseRakendamine
{
   
    public class Auto : ISõiduk
    {
        public string Nimi { get; set; }
        public double Kütusekulu { get; set; }  // литров на 100 км
        public double Vahemaa { get; set; }     // км

        public Auto(string nimi, double kütusekulu, double vahemaa)
        {
            Nimi = nimi;
            Kütusekulu = kütusekulu;
            Vahemaa = vahemaa;
        }

        public double ArvutaKulu()
        {
            return Kütusekulu * Vahemaa / 100;
        }

        public double ArvutaVahemaa()
        {
            return Vahemaa;
        }

        public override string ToString()
        {
            return $"Auto: {Nimi}, Vahemaa: {Vahemaa} km, Kulu: {ArvutaKulu():F2} L";
        }
    }
}
