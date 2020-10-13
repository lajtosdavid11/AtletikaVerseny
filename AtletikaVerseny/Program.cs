using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaVerseny
{
    class Program
    {
        static List<Atleta> lista = new List<Atleta>();
        static List<string> egyesuletek = new List<string>();
        static List<string> fajlba = new List<string>();
        static void beolv()
        {
            Console.WriteLine("Adatok Beolvasása");
            StreamReader sr = new StreamReader("tavol.csv");
            while (!sr.EndOfStream)
            {
                lista.Add(new Atleta(sr.ReadLine()));
            }
        }

        static void kettes()
        {
            Console.WriteLine("\n");
            Console.WriteLine("2. feladat");
            foreach (var t in lista)
            {
                Console.WriteLine(t.VezNev +" "+  t.Ugras);
            }
        }

        static void harmas()
        {
            
            Console.WriteLine("\n");
            Console.WriteLine("3. feladat");
            foreach (var t in lista)
            {
                if (!egyesuletek.Contains(t.Egyesulet))
                {
                    egyesuletek.Add(t.Egyesulet);
                }
            }

            for (int i = 0; i < egyesuletek.Count; i++)
            {
                Console.WriteLine(egyesuletek[i]);
            } 
        }

        static void negyes()
        {
            Console.WriteLine("\n");
            Console.WriteLine("4. feladat");
            int max = 0;
            foreach (var t in lista)
            {
                if (t.Ugras > max)
                {
                    max = t.Ugras;
                }
            }
            
            foreach (var m in lista)
            {
                if (m.Ugras == max)
                {
                    Console.WriteLine("Legnagyobb ugrás: {0} {1}",m.VezNev,m.Ugras);
                }
            }
        }

        static void otos()
        {
            Console.WriteLine("\n");
            
            Console.WriteLine("5. feladat");
            double sum = 0;
            double atlag = 0;
            foreach (var t in lista)
            {
                sum += t.Ugras;
            }
            Console.WriteLine("Átlagos ugrások: {0}",sum/lista.Count);
            atlag = sum / lista.Count;
            int db = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Ugras < atlag)
                {
                    db++;
                }
            }
            Console.WriteLine("Átlag alatt teljesítők száma {0}", db);

        }

        static void hatos()
        {
            Console.WriteLine("\n");
            Console.WriteLine("6. feladat \n Fájlba írás");
            StreamWriter sw = new StreamWriter("versenyzok.txt");
            foreach (var t in lista)
            {
                fajlba.Add(t.Rajtszam + t.VezNev);
            }
            for (int i = 0; i < fajlba.Count; i++)
            {
                sw.WriteLine(lista[i].VezNev + ";" + lista[i].Rajtszam) ;
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            beolv();
            kettes();
            harmas();
            negyes();
            otos();
            hatos();
            //foreach (var t in lista)
            //{
            //    Console.WriteLine(t.Rajtszam+ ";" + t.KerNev + ";"+t.VezNev+";"+t.Egyesulet+";"+t.Ugras);
            //}



            Console.ReadKey();
        }
    }
}
