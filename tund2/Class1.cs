using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tund2;

namespace tund2
{
    internal class StartClass
   

namespace TasksConsoleApp
    {
        class Program
        {
            static void Main()
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                while (true)
                {
                    Console.WriteLine("\nВыберите задание (1–8) или 0 для выхода:");
                    Console.WriteLine("1) Имя Juku → кино + выбор билета по возрасту");
                    Console.WriteLine("2) Два имени → сообщить, что они сегодня соседи по парте");
                    Console.WriteLine("3) Площадь пола + (опционально) стоимость замены");
                    Console.WriteLine("4) Восстановить исходную цену по цене со скидкой 30%");
                    Console.WriteLine("5) Сказать, выше ли температура 18°С");
                    Console.WriteLine("6) Классификация по росту (без учёта пола)");
                    Console.WriteLine("7) Классификация по росту с учётом пола");
                    Console.WriteLine("8) Покупки в магазине: молоко, булка, хлеб");
                    Console.Write("Ваш выбор: ");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Task1_JukuCinema();
                            break;
                        case "2":
                            Task2_DeskNeighbors();
                            break;
                        case "3":
                            Task3_RoomAreaAndRenovation();
                            break;
                        case "4":
                            Task4_RestoreOriginalPrice();
                            break;
                        case "5":
                            Task5_TemperatureCheck();
                            break;
                        case "6":
                            Task6_HeightCategory();
                            break;
                        case "7":
                            Task7_HeightCategoryWithGender();
                            break;
                        case "8":
                            Task8_Shopping();
                            break;
                        case "0":
                            Console.WriteLine("Выход. До встречи!");
                            return;
                        default:
                            Console.WriteLine("Неверный выбор. Повторите.");
                            break;
                    }

                    Console.WriteLine("\nНажмите Enter, чтобы продолжить...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
















            //public static void Main(string[] args)
            //{
            //    Random rnd = new Random();
            //    int kuu_number = rnd.Next(1, 12);
            //    string nimetus = Osal_funktsionid.Kuu_nimetus(kuu_number);
            //    Console.WriteLine($"Nr: {kuu_number}-{nimetus}");
            //    Console.WriteLine("kas tahad dekodeerida arv->nimetusse?");
            //    string vastus = Console.ReadLine();
            //    if ( vastus.ToLower() !="jah")
            //    {
            //        Console.WriteLine("ok!");
            //    }
            //    else
            //    {
            //        try
            //        {
            //            Console.WriteLine("Sisesta kuu number 1-12");
            //            kuu_number = int.Parse(Console.ReadLine());
            //            Console.WriteLine(Osal_funktsionid.Hooaeg(kuu_number));
            //        }
            //        catch (Exception )
            //        {
            //            Console.WriteLine("Viga! Proovi uuesti");
            //        }

            //    }



























        }
    }
}

//            Console.OutputEncoding = Encoding.UTF8;
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.ForegroundColor = ConsoleColor.Blue;

//            Console.WriteLine("Tere tulemast! Mis on sinu nimi?");
//            string tekst = Console.ReadLine();
//            Console.WriteLine($"{tekst}, Rõõm näha!");
//            Console.Clear();
//            int a = 1000;
//            char taht = 'A';
//            Console.Write($"Esimene arv on {a}, Sisesta b=...");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Esimene arv on {0}, Sisesta {1}. Summa on {2}", a, b, a + b);
//            Console.Clear();
//            Console.WriteLine("Ujukomaarv");
//            double d = double.Parse(Console.ReadLine());
//            Console.WriteLine(d);
//            Console.WriteLine("Float");
//            float f = float.Parse(Console.ReadLine());
//            Console.WriteLine(f);
//            bool t = true;

//            Console.Clear();

//            Random rnd = new Random();
//            a = rnd.Next(-100, 200);
//            Console.WriteLine(a);

//            float vastus = Osa1_Funktsioonid.Kalkulaator(f, a);
//            Console.WriteLine($"Kalkulaatori tulemus: {vastus}");
//        }
//    }
//}