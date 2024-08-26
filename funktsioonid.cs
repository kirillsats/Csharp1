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
    }
}
