using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dolgozokLinq13.a
{
    internal class Program
    {
        static List<Dolgozo> dolgozok = new List<Dolgozo>();    
        static void Main(string[] args)
        {
            AdatBeolvas();
            //AdatKiir();

            //1.feladat
            Console.WriteLine("1.feladat");
            Console.WriteLine($"Jutalmak összege: {dolgozok.Sum(x=>x.Jutalom)} Ft");

            //2.feladat
            Console.WriteLine("2.feladat");
            Console.WriteLine($"Fizetesek átlaga: {dolgozok.Average(x=>x.Fizetes):F0} Ft");

            //3.feladat
            Console.WriteLine("3.feladat");
            Console.WriteLine(dolgozok.Any(x=>x.Telepules=="Recsk")?"Van recski dolgozó.":"Nincs recski dolgozó.");

            //4.feladat
            Console.WriteLine("4.feladat");
            Console.WriteLine($"Tatai dolgozók: {dolgozok.Where(x=>x.Telepules=="Tata").Count()} fő");

            //5.feladat
            Console.WriteLine("5.feladat");
            dolgozok.ForEach(w => Console.WriteLine($"{w.Nev,-25}{w.Fizetes}"));

            //6.feladat
            Console.WriteLine("6.feladat");
            dolgozok
                .OrderByDescending(x=>x.Fizetes)
                .Take(1)
                .ToList()
                .ForEach(w=>Console.WriteLine(w.Nev + " " + w.Fizetes));

            //7.feladat
            Console.WriteLine("7.feladat");
            dolgozok.Where(x => x.Fizetes > dolgozok.Average(y => y.Fizetes)).ToList().ForEach(w => Console.WriteLine(w.Nev));

            //8.feladat
            Console.WriteLine("8.feladat");
            dolgozok.OrderBy(x=>x.Szuletes).Take(1).ToList().ForEach(w => Console.WriteLine($"Legidősebb dolgozó: "+w.Nev));


            Console.ReadKey();
        }

        private static void AdatKiir()
        {
            foreach (var item in dolgozok)
            {
                Console.WriteLine(item.Nev);
            }
        }

        private static void AdatBeolvas()
        {
            /*
            using (StreamReader olvas = new StreamReader("dolgozok_300.txt"))
            {
                olvas.ReadLine();
                while (!olvas.EndOfStream)
                {
                    
                    string[] sor = olvas.ReadLine().Split(';');
                    Dolgozo egyDolgozo = new Dolgozo
                        (
                        int.Parse(sor[0]),
                        sor[1],
                        sor[2],
                        sor[3],
                        sor[4],
                        int.Parse(sor[5]),
                        int.Parse(sor[6]),
                        DateTime.Parse(sor[7]),
                        DateTime.Parse(sor[8]),
                        sor[9]
                        );
                    dolgozok.Add(egyDolgozo); 
                }
            }
            */
            try
            {
                dolgozok = File.ReadAllLines("dolgozok_300.txt")
                .Skip(1)
                .Select(sor => sor.Split(';'))
                .Select(adat => new Dolgozo(
                        int.Parse(adat[0]),
                        adat[1],
                        adat[2],
                        adat[3],
                        adat[4],
                        int.Parse(adat[5]),
                        int.Parse(adat[6]),
                        DateTime.Parse(adat[7]),
                        DateTime.Parse(adat[8]),
                        adat[9]
                        ))
                .ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hiba! {e.Message}");
            }

            
        }
    }
}
