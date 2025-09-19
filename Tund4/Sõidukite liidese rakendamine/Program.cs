using SõidukiteLiideseRakendamine;
using System;
using System.Collections.Generic;
using System.IO;

namespace SoidukiteLiideseRakendamine
{
    class Program
    {
        static void Main()
        {
            List<ISõiduk> soidukid = new List<ISõiduk>();
            double koguKulu = 0;

            try
            {
                string[] lines = File.ReadAllLines("soidukid.txt");
                foreach (string line in lines)
                {
                    string[] osad = line.Split(',');
                    string tüüp = osad[0].Trim().ToLower();

                    switch (tüüp)
                    {
                        case "auto":
                            soidukid.Add(new Auto(osad[1], double.Parse(osad[2]), double.Parse(osad[3])));
                            break;
                        case "jalgratas":
                            soidukid.Add(new Jalgratas(osad[1], double.Parse(osad[2])));
                            break;
                        case "buss":
                            soidukid.Add(new Buss(osad[1], double.Parse(osad[2]), double.Parse(osad[3]), int.Parse(osad[4])));
                            break;
                        case "tõukeratas":
                            soidukid.Add(new Elektritõukeratas(osad[1], double.Parse(osad[2]), double.Parse(osad[3])));
                            break;
                        default:
                            Console.WriteLine($"Tundmatu sõiduki tüüp: {tüüp}");
                            break;
                    }
                }

                Console.WriteLine("Soidukite info:");
                foreach (var soiduk in soidukid)
                {
                    Console.WriteLine(soiduk.ToString());
                    koguKulu += soiduk.ArvutaKulu();
                }

                Console.WriteLine($"\nKogu kulu kõikide sõidukite peale: {koguKulu:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла или обработке данных: " + ex.Message);
            }
        }
    }
}
