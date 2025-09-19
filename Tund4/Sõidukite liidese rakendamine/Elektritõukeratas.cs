namespace SõidukiteLiideseRakendamine
{
    
    public class Elektritõukeratas : ISõiduk
    {
        public string Nimi { get; set; }
        public double Vahemaa { get; set; }
        public double Energiakulu { get; set; }

        public Elektritõukeratas(string nimi, double vahemaa, double energiakulu)
        {
            Nimi = nimi;
            Vahemaa = vahemaa;
            Energiakulu = energiakulu;
        }

        public double ArvutaKulu()
        {
            return Energiakulu * Vahemaa / 100;
        }

        public double ArvutaVahemaa()
        {
            return Vahemaa;
        }

        public override string ToString()
        {
            return $"Elektritõukeratas: {Nimi}, Vahemaa: {Vahemaa} km, Energiakulu: {ArvutaKulu():F2} kWh";
        }
    }
}
