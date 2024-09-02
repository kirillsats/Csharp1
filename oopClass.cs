using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_KirillSats
{
    public class oopClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n");
            List<Inimene> inimesed = new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr I";
            inimene1.Vanus = 352;
            inimene1.Pikkus = 200;
            inimene1.Kaal = 110;
            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            inimene2.Pikkus = 189;
            inimene2.Sugu = Sugu.naine;
            inimene2.Kaal = 70;
            Inimene inimene3 = new Inimene("Marina", 18, Sugu.naine);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Irina", 18));
            foreach (Inimene inemene in inimesed)
            {
                Console.WriteLine($"{inemene.Nimi} on " + $"{inemene.Vanus} aastat vana" + $" Ta on {inemene.Sugu}. SBI = {inemene.HB_vorrand()}");

            }

            //Ülesanne 1
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Sisesta numbrid:");
            string numbstr = Console.ReadLine();
            string[] numblist = numbstr.Split(" ");
            int[] newlist = new int[numblist.Length];

            for (int i = 0; i < numblist.Length; i++)
            {
                int a;
                if(i == 0)  
                {
                    a = int.Parse(numblist[numblist.Length-1]) + int.Parse(numblist[i+1]);
                }
                else if (i == numblist.Length -1)
                {
                    a = int.Parse(numblist[i-1]) + int.Parse(numblist[0]);
                }
                else
                {
                    a = int.Parse(numblist[i-1]) + int.Parse(numblist[i+1]);
                }
                newlist[i] = a;
            }
            Console.WriteLine("New list of sums:");
            Console.WriteLine(string.Join(", ", newlist));
            
            
            
            
            
            
            
            //ülesanne 2
            Random random = new Random();
            int[] numbers = new int[20];

            
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = random.Next(1, 101); 
            }
            //Päärisnumbrid
            List<int> evenNumbers = numbers.Where(n => n% 2 == 0).ToList();
            //Paritu numbrid
            List<int> oddNumbers = numbers.Where(n => n% 2 != 0).ToList();
            //Uus numekiri, kus kõigepealt lähevad ebaühentlased
            List<int> sortNumbers = evenNumbers.Concat(oddNumbers).ToList();

            Console.WriteLine("Sorteeritud numbrid: ");
            sortNumbers.ForEach(n => Console.WriteLine(n + " "));
            

            

            
            
            



            Console.WriteLine("\n");
            List<Inimene> Inimesed = new List<Inimene>();
            Inimene Inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr I";
            inimene1.Vanus = 352;
            Inimene Inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            Inimene Inimene3 = new Inimene("Marina", 18);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Irina", 18));
            foreach (Inimene inemene in inimesed)
            {
                Console.WriteLine($"{inemene.Nimi} on " + $"{inemene.Vanus} aastat vana");

            }

            Auto auto1 = new Auto("681MRP", Color.Bisque, inimene1);
            Auto auto2 = new Auto("180ABC", Color.NavajoWhite, inimene2);
            Auto auto3 = new Auto("079TDI", Color.Red, inimene3);
            auto1.KelleOmaAuto();
            Dictionary<Auto, Inimene> register = new Dictionary<Auto, Inimene>();
            register.Add(auto1, inimene2);
            register.Add(auto2, inimene3);
            register.Add(auto3, inimene3);
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key.Regnumber} -  { item.Value.Nimi}");

            }
            foreach (KeyValuePair<Auto, Inimene> pair in register)
            {
                Console.WriteLine (pair.Key.Regnumber + "-" + pair.Value.Nimi);
            }

        }



    }




}
