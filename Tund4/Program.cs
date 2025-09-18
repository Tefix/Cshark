using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Program.cs
{
    class Opilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; }

        public double Keskmine()
        {
            return Hinded.Average();
        }
    }

    class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n--- MENÜÜ ---");
                Console.WriteLine("1. Õpilased ja hinded");
                Console.WriteLine("2. Valuutakalkulaator");
                Console.WriteLine("0. Välju");
                Console.Write("Vali: ");
                string valik = Console.ReadLine();

                if (valik == "1")
                    KäivitaOpilased();
                else if (valik == "2")
                    KäivitaValuutakalkulaator();
                else if (valik == "0")
                    break;
                else
                    Console.WriteLine("Vale valik!");
            }
        }

        static void KäivitaOpilased()
        {
            List<Opilane> opilased = new List<Opilane>();

            Console.WriteLine("Mitu õpilast soovid sisestada?");
            int kogus = int.Parse(Console.ReadLine());

            for (int i = 0; i < kogus; i++)
            {
                Console.WriteLine($"\nSisesta {i + 1}. õpilase nimi:");
                string nimi = Console.ReadLine();

                List<int> hinded = new List<int>();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Sisesta hinne {j + 1} (täisarv 1-5):");
                    int hinne;
                    while (!int.TryParse(Console.ReadLine(), out hinne) || hinne < 1 || hinne > 5)
                    {
                        Console.WriteLine("Vale sisestus! Palun sisesta täisarv 1-5:");
                    }
                    hinded.Add(hinne);
                }

                opilased.Add(new Opilane { Nimi = nimi, Hinded = hinded });
            }

            double maxKeskmine = opilased.Max(o => o.Keskmine());
            Opilane parimOpilane = opilased.First(o => Math.Abs(o.Keskmine() - maxKeskmine) < 0.0001);

            Console.WriteLine("\nÕpilaste keskmised hinded:");
            foreach (var o in opilased)
            {
                Console.WriteLine($"{o.Nimi} – keskmine hinne: {o.Keskmine():F2}");
            }

            Console.WriteLine($"\nKõrgeima keskmise hinde sai: {parimOpilane.Nimi} ({parimOpilane.Keskmine():F2})");

            using (StreamWriter sw = new StreamWriter("opilased.txt"))
            {
                foreach (var o in opilased)
                {
                    sw.WriteLine($"{o.Nimi}; hinded: {string.Join(", ", o.Hinded)}; keskmine: {o.Keskmine():F2}");
                }
                sw.WriteLine($"\nParim õpilane: {parimOpilane.Nimi} ({parimOpilane.Keskmine():F2})");
            }

            Console.WriteLine("\nAndmed on salvestatud faili 'opilased.txt'");
        }

        static void KäivitaValuutakalkulaator()
        {
            Dictionary<string, Valuuta> valuutad = new Dictionary<string, Valuuta>()
            {
                { "EUR", new Valuuta("EUR", 1.0) },
                { "USD", new Valuuta("USD", 1.08) },
                { "GBP", new Valuuta("GBP", 0.85) },
                { "JPY", new Valuuta("JPY", 160.0) }
            };

            while (true)
            {
                Console.WriteLine("\nSaadaolevad valuutad: EUR, USD, GBP, JPY");
                Console.WriteLine("Sisesta valuuta nimetus (või kirjuta exit, et väljuda):");
                string nimi = Console.ReadLine().ToUpper();

                if (nimi == "EXIT")
                    break;

                if (!valuutad.ContainsKey(nimi))
                {
                    Console.WriteLine("Viga: sellist valuutat ei leitud.");
                    continue;
                }

                Console.WriteLine("Sisesta summa:");
                double summa;
                while (!double.TryParse(Console.ReadLine(), out summa) || summa <= 0)
                {
                    Console.WriteLine("Viga! Palun sisesta positiivne arv:");
                }
            

                Valuuta val = valuutad[nimi];
                double eurSumma = summa / val.KurssEurSuhte;
                Console.WriteLine($"{summa} {nimi} = {eurSumma:F2} EUR");

                Valuuta usd = valuutad["USD"];
                double usdSumma = eurSumma * usd.KurssEurSuhte;
                Console.WriteLine($"{eurSumma:F2} EUR = {usdSumma:F2} USD");
            }
        }
    }

    class Valuuta
    {
            public string Nimetus { get; set; }
        public double KurssEurSuhte { get; set; }

        public Valuuta(string nimetus, double kurss)
        {
            Nimetus = nimetus;
            KurssEurSuhte = kurss;
        }
    }
}

