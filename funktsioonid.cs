using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_KirillSats
{
    internal class funktsioonid
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere kallis {0}", nimi);
        }
        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }
        // Loo Arvuta() funktsioon, mis sõltub 3 parameetrist: tehe, arv1, arv2. Kasuta if konstruktsioon. Tulemus kuva ekraanile.


        public static int Arvuta(char tehe, int arv1, int arv2)
        {
            int tulemus = 0;

            if (tehe == '+')
            {
                tulemus = arv1 + arv2;
            }
            else if (tehe == '-')
            {
                tulemus = arv1 - arv2;
            }
            else
            {
                Console.WriteLine("Viga! Tundmatu tehe: " + tehe);
                return 0;
            }

            return tulemus;
        }
        //Pinginaabrid #1
        public static string Naaber(string nimi1, string nimi2)
        {
            return "Naaber on " + nimi1 + " ja " + nimi2;
        }

        //Temperatuur #2
        public class Funktsioonid
        {
            public string Temp(double temperatuur)
            {
                if (temperatuur > 18)
                {
                    return "Temperatuur on üle kaheksateistkümne kraadi";
                }
                else if (temperatuur == 18)
                {

                    return "Hea temperatuur";
                }
                else
                {
                    return "Temperatuur on alla kaheksateistkümne kraadi";
                }
            }
        }
        //Soodushind #3
        public static double alghind(double praeguneHind, double soodustusProtsent)
        {
            // Находим стартовую цену, зная текущую цену и процент скидки
            double alghind = praeguneHind / (1 - soodustusProtsent / 100);
            return alghind;
        }

        //Pikkus #4
        public static string Pikkuse_analuus(double kasv)
        {
            string analuus;
            if (kasv < 1.6)
            {
                analuus = "Lühike kasv";
                
            }
            else if (kasv < 1.8)
            {
                analuus = "Pikkus on keskmine.";
            }
            else
            {
                analuus = "Pikkus on kõrge.";
            }
            return analuus;
        }

    }
}