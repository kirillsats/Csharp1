using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpv23_KirillSats;
using static TARpv23_KirillSats.funktsioonid;

namespace TARpv23_KirillSatsˇ               //ПРЕЖДЕ ЧЕМ ЗАПУСТИТЬ ОДНО НУЖНО ЗАКОММЕНТИТЬ ОСТАЛЬНОЕ
{
    public class mainclass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*Console.WriteLine("Hello World!");
            string nimetus = "Python";
            Console.WriteLine("Hello {0}", nimetus);
            funktsioonid.Tere(nimetus);
            Console.Write("Sisesta esimine arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus = funktsioonid.Liitmine(a, b);
            Console.WriteLine("Teie vastus on: {0}", vastus);
            double arv = 5.123456;
            vastus = funktsioonid.Liitmine(a, (int)arv);
            Console.WriteLine("Teie vastus on: {0}", vastus);
            char taht = 'A';
            if (vastus == 0)
            {
                Console.WriteLine(vastus);
            }
            else
            {
                Console.WriteLine(vastus);
            }*/


            //Arvutama
           /* Console.Write("Sisesta sümbol: ");
            char sümbol = char.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta esimene arv:");
            int o = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine arv:");
            int p = int.Parse(Console.ReadLine());

            int tulemus = funktsioonid.Arvuta(sümbol, o, p);

            Console.WriteLine($"Teie vastus on: {tulemus}");*/



            //Naaber #1
            /*Console.Write("Sisestage oma nime: ");
            string nimi1 = Console.ReadLine();       // Считываем введённое имя и сохраняем его в переменную 'nimi'
            Console.WriteLine("Sisestage lähima inimese nimi: ");
            string nimi2 = Console.ReadLine();
            string naabrid = funktsioonid.Naaber(nimi1, nimi2);
            Console.WriteLine(naabrid);*/


            //Temperatuur #2

            /*Funktsioonid funktsioonid = new Funktsioonid();


            Console.Write("Sisestage temperatuur: ");
            double temperatuur = double.Parse(Console.ReadLine());

            string tulemus = funktsioonid.Temp(temperatuur);

            Console.WriteLine(tulemus);*/

            //Soodushind #3

            double ArvutaHind(double praeguneHind, double soodustusProtsent)
            {
                return praeguneHind / (1 - soodustusProtsent / 100);
            }

            Console.Write("Sisestage praegune hind: ");
            double praeguneHind = double.Parse(Console.ReadLine());

            Console.Write("Sisestage soodustus protsentides: ");
            double soodustusProtsent = double.Parse(Console.ReadLine());

            double startHind = funktsioonid.alghind(praeguneHind, soodustusProtsent);
            Console.WriteLine("Start hind, enne soodustust, on: " + startHind);

            //Pikkus #4
            
            /*Console.Write("Sisestage oma pikkus (m): ");
            double kasv = double.Parse(Console.ReadLine());
            string tulemus = funktsioonid.Pikkuse_analuus(kasv);

            Console.WriteLine(tulemus);*/






        }

    }
}