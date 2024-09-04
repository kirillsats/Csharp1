using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_KirillSats
{
    public enum Eluviis
    {
        Istuv, Vähene, Mõõdukas, Kõrge, Väga_Kõrge
    }

    public enum Sugu
    {
        mees,
        naine
    }
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public Sugu Sugu { get; set; }
        public int Pikkus { get; set; }
        public double Kaal { get; set; }
        public Inimene()
        {

        }
        public Inimene(string nimi)
        {
            Nimi = nimi;
        }
        public Inimene(string nimi, int vanus = 2)
        {
            Nimi = nimi;
            Vanus = vanus;

        }

        public Inimene(string nimi, int vanus, Sugu sugu = Sugu.mees)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;

        }

        //3 ülesanne. 

        public double HB_vorrand(Eluviis eluviis = Eluviis.Istuv)
        {
            double SBI = 0;
            if (Sugu == Sugu.mees)
            {
                SBI = 66 + (13.7 * Kaal) + (5 * Pikkus) - (6.8 * Vanus);
            }
            else
            {
                SBI = 655 + (9.5 * Kaal) + (1.8 * Pikkus) - (4.7 * Vanus);
            }
            switch (eluviis)
            {
                case Eluviis.Istuv:
                    SBI = SBI * 1.2;
                    break;
                case Eluviis.Vähene:
                    SBI = SBI * 1.375;
                    break;
                case Eluviis.Mõõdukas:
                    SBI = SBI * 1.55;
                    break;
                case Eluviis.Kõrge:
                    SBI = SBI * 1.725;
                    break;
                case Eluviis.Väga_Kõrge:
                    SBI = SBI * 1.9;
                    break;
            }
            return Math.Round(SBI, 1);
        }
    }
}
