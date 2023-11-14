using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using balkezesek;
using System.IO;

namespace balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Baseball> adatok = new List<Baseball>();
            StreamReader sr = new StreamReader("balkezesek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var adatoks = sr.ReadLine();
                adatok.Add(new Baseball(adatoks[0], adatoks[1], adatoks[2], adatoks[3], adatoks[4]);
            }
            sr.Close();
            Console.ReadLine();

            Console.WriteLine($"3. feladat: {adatok.Count}");
            Console.WriteLine("4. feladat:");
            adatok.Where(x => x.Utolso.ToString("yyyy-MM").Contains("1999-10")).ToList().ForEach(x => Console.WriteLine($"\t{x.Nev} {Math.Round(x.Magassag * 2.54, 1)} cm"));

            //Feladat:5
            bool BenneVan = false;
            int BevittSzam = 0;
            Console.WriteLine("5. feladat:");
            Console.Write("Kérek egy 1990 és 1999 közötti évszámot!: ");
            while (BenneVan == false)
            {
                BevittSzam = Convert.ToInt32(Console.ReadLine());
                if (BevittSzam >= 1990 && BevittSzam <= 1999)
                {
                    BenneVan = true;
                    Console.WriteLine("Ügyes vagy:)");
                }
                else
                {
                    Console.Write("Hibás adat kérek egy 1990 és 1999 közötti évszámot!:");
                }
            }
            //Feladat:6
            double OsszSuly = 0;
            double Darab = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (BevittSzam >= adatok[i].Elso.Year && BevittSzam <= adatok[i].Utolso.Year)
                {
                    OsszSuly += adatok[i].Suly;
                    Darab++;
                }
            }
            double Atlag = OsszSuly / Darab;
            Console.WriteLine($"6. feladat:{Math.Round(Atlag, 2)} font ");
        }
        }
    }