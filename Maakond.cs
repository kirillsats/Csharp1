using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_KirillSats
{
    public class Maakond
    {



        // Метод для поиска столицы по названию округа
        public static void LeiaLinnMaakonnaJargi(Dictionary<string, string> maakonnad)
        {
            Console.WriteLine("Sisestage maakonna nimi:");
            string maakond = Console.ReadLine();

            if (string.IsNullOrEmpty(maakond))
            {
                Console.WriteLine("Palun sisestage kehtiv maakonna nimi.");
                return;
            }

            foreach (var paar in maakonnad)
            {
                if (paar.Value.ToLower() == maakond.ToLower())
                {
                    Console.WriteLine($"Maakonna {maakond} pealinn: {paar.Key}");
                    return;
                }
            }

            Console.WriteLine("Maakond ei leitud.");
        }

        // Метод для поиска округа по названию города
        public static void LeiaMaakondLinnaJargi(Dictionary<string, string> maakonnad)
        {
            Console.WriteLine("Sisestage linna nimi:");
            string linn = Console.ReadLine();

            if (string.IsNullOrEmpty(linn))
            {
                Console.WriteLine("Palun sisestage kehtiv linna nimi.");
                return;
            }

            if (maakonnad.ContainsKey(linn))
            {
                Console.WriteLine($"Linna {linn} maakond: {maakonnad[linn]}");
            }
            else
            {
                Console.WriteLine("Linn ei leitud.");
            }
        }

        // Метод для добавления новой пары город-округ
        public static void LisaUusMaakond(Dictionary<string, string> maakonnad)
        {
            Console.WriteLine("Sisestage linna nimi:");
            string linn = Console.ReadLine();

            Console.WriteLine("Sisestage maakonna nimi:");
            string maakond = Console.ReadLine();

            if (string.IsNullOrEmpty(linn) || string.IsNullOrEmpty(maakond))
            {
                Console.WriteLine("Palun sisestage kehtivad andmed.");
                return;
            }

            if (maakonnad.ContainsKey(linn))
            {
                Console.WriteLine("Linn on juba olemas.");
            }
            else
            {
                maakonnad[linn] = maakond;
                Console.WriteLine("Uus linn ja maakond on lisatud.");
            }
        }

        // Метод для проверки знаний пользователя
        public static void KontrolliTeadmisi(Dictionary<string, string> maakonnad)
        {
            Random rand = new Random();
            int index = rand.Next(maakonnad.Count);
            var city = "";
            var region = "";
            int currentIndex = 0;

            foreach (var pair in maakonnad)
            {
                if (currentIndex == index)
                {
                    city = pair.Key;
                    region = pair.Value;
                    break;
                }
                currentIndex++;
            }

            Console.WriteLine($"Milline maakond kuulub linnale {city}?");
            string userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == region.ToLower())
            {
                Console.WriteLine("Õige vastus!");
            }
            else
            {
                Console.WriteLine($"Vale vastus. Õige vastus on {region}.");
            }
        }
    }
}

