namespace tund2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

internal class Osal_funktsionid
{

    public static string Kuu_nimetus(int kuu_nr)
    {
        string kuu = "";
        switch (kuu_nr)
        {
            case 1: kuu = "Jaanuar"; break;
            case 2: kuu = "Veebruar"; break;
            case 3: kuu = "Märts"; break;
            case 4: kuu = "Aprill"; break;
            case 5: kuu = "Mai"; break;
            case 6: kuu = "Juuni"; break;
            case 7: kuu = "Juuli"; break;
            case 8: kuu = "August"; break;
            case 9: kuu = "September"; break;
            case 10: kuu = "Oktoober"; break;
            case 11: kuu = "November"; break;
            case 12: kuu = "Detsember"; break;

            default:
                kuu = "Vigane kuu number";
                break;





        }
        return kuu;

    }
    public static string Hooaeg(int kuu_nr)
    {
        string hoo = "";
        if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12)

        {
            hoo = "Talv";
        }
        else if (kuu_nr > 2 && kuu_nr < 6)
        {
            hoo = "Kevad";
        }
        else if (kuu_nr > 5 && kuu_nr < 9)
        {
            hoo = "Suvi";
        }
        else if (kuu_nr > 8 && kuu_nr < 12)
        {
            hoo = "Sügis";
        }
        else
        {
            hoo = "Vigane kuu number";
        }

        return hoo;

    }

    static void Task1_JukuCinema()
    {
        Console.WriteLine("Sisestage nimi: ");
        string nimi = Console.ReadLine();
        if (nimi != null && nimi.ToLower() == "juku")
        {
            Console.WriteLine("Lähme Jukuga kinno!");
            Console.Write("Sisestage Juku vanus (aastates): ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 0 || age > 100)
                {
                    Console.WriteLine("Viga vanuse andmetes.");
                }
                else if (age < 6)
                {
                    Console.WriteLine("Pilet: tasuta (kuni 6 a).");
                }
                else if (age <= 14)
                {
                    Console.WriteLine("Pilet: laste pilet (6–14).");
                }
                else if (age <= 65)
                {
                    Console.WriteLine("Pilet: täispilet (15–65).");
                }
                else
                {
                    Console.WriteLine("Pilet: sooduspilet (>65).");
                }
            }
            else
            {
                Console.WriteLine("Viga: sisestage arv.");
            }
        }
        else
        {
            Console.WriteLine("Täna lähme kinno ainult Jukuga.");
        }
    }
}


