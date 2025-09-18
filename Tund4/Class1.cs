using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Program
{
    // Класс продукта
    public class Toode
    {
        public string Nimi { get; set; }
        public double Kalorid100g { get; set; }

        public Toode(string nimi, double kalorid)
        {
            Nimi = nimi;
            Kalorid100g = kalorid;
        }
    }

    // Класс человека
    public class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; }
        public double Pikkus { get; set; }
        public double Kaal { get; set; }
        public double Aktiivsustase { get; set; }

        public Inimene(string nimi, int vanus, string sugu, double pikkus, double kaal, double aktiivsus)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Pikkus = pikkus;
            Kaal = kaal;
            Aktiivsustase = aktiivsus;
        }

        public double ArvutaKalorid()
        {
            double BMR = 0;
            if (Sugu.ToLower() == "mees")
                BMR = 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
            else if (Sugu.ToLower() == "naine")
                BMR = 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);
            else
                throw new Exception("Sugu peab olema 'mees' või 'naine'");

            return BMR * Aktiivsustase;
        }
    }

    public static class Funktsioonid
    {
        // Чтение продуктов из файла
        public static List<Toode> LoeToidud(string path)
        {
            List<Toode> toidud = new List<Toode>();

            if (File.Exists(path))
            {
                foreach (var line in File.ReadAllLines(path))
                {
                    string[] osad = line.Split(',');
                    if (osad.Length >= 2 && double.TryParse(osad[1], out double kalorid))
                    {
                        toidud.Add(new Toode(osad[0], kalorid));
                    }
                }
            }

            return toidud;
        }

        // Вывод порций продуктов
        public static void NäitaPortsid(List<Toode> toidud, double kaloridPäevas)
        {
            if (toidud.Count == 0)
            {
                Console.WriteLine("Toidunimekiri on tühi.");
                return;
            }

            double kaloridPerProduct = kaloridPäevas / toidud.Count;

            foreach (var t in toidud)
            {
                double grammid = kaloridPerProduct / t.Kalorid100g * 100;
                Console.WriteLine($"{t.Nimi}: {grammid:F0} g ({kaloridPerProduct:F0} kcal)");
            }
        }
    }
    class Õpilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; }

        public Õpilane(string nimi, List<int> hinded)
        {
            Nimi = nimi;
            Hinded = hinded;
        }

        public double KeskmineHinne()
        {
            return Hinded.Average();
        }
    }
}
