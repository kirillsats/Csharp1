using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_KirillSats
{
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


        public double HB_vorran()
        {
            double SBI = 0;
            if (SBI == 0)
            {
                SBI = 66 + (13.7 * Kaal) + (5 * Pikkus) - (6.8 * Vanus);
            }
            else
            {
                SBI = 655 + (9.5 * Kaal) + (1.8 * Pikkus) - (4.7 * Vanus);
            }
            return SBI;

        }
    }
}
