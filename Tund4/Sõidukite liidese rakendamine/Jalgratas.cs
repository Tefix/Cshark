namespace SõidukiteLiideseRakendamine
{
    
    public class Jalgratas : ISõiduk
    {
        public string Nimi { get; set; }
        public double Vahemaa { get; set; }

        public Jalgratas(string nimi, double vahemaa)
        {
            Nimi = nimi;
            Vahemaa = vahemaa;
        }

        public double ArvutaKulu()
        {
            return 0; 
        }

        public double ArvutaVahemaa()
        {
            return Vahemaa;
        }

        public override string ToString()
        {
            return $"Jalgratas: {Nimi}, Vahemaa: {Vahemaa} km, Kulu: {ArvutaKulu():F2} L";
        }
    }
}
