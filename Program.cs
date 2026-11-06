using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace TombokGyakorlas
{
    internal class Program
    {
        static Random r = new Random();
        static void Feladat6()
        {
            int[] tomb = new int[5];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem az {i+1}. számot: ");
                int szam = Convert.ToInt32(Console.ReadLine());
                tomb[i] = szam;
            }
            foreach (int item in tomb)
            {
                Console.WriteLine(item);
            }
            for (int i = tomb.Length - 1; i > -1; i--)
            {
                Console.WriteLine(tomb[i]);
            }
            for (int i = 0; i < tomb.Length; i += 2)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.Write("Kérek egy számot (1-5): ");
            int keres = Convert.ToInt32(Console.ReadLine());
            foreach (int item in tomb)
            {
                if (keres == item)
                {
                    Console.WriteLine($"A megadott szám: {item}");
                }
            }
        }

        static void Feladat13()
        {
            int[] tomb = new int[20];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-100, 99);
                Console.WriteLine(tomb[i]);
            }

        }

        //Karneváli Tombola
        static int[] sorsjegyek = new int[100];
        static string[] nyeremenyek =
        {
            "Élményhajózás a helyi tavon","Vacsora egy exkluzív étteremben", "Belépő a városi uszodába", "Kosárlabda", "Mozijegy-páros"
        };
        static int[] nyertesek = new int[5];

        static void SorsjegyekFeltoltese()
        {
            for (int i = 0; i < sorsjegyek.Length; i++)
            {
                sorsjegyek[i] = i + 1;
            }
        }

        static bool MarKihuzott(int szam, int db)
        {
            for (int j = 0; j < db; j++)
            {
                if (nyertesek[j] == szam)
                {
                    return true;
                }
            }
            return false;
        }

        static void TombolaSorsolas()
        {
            for (int i = 0; i < nyeremenyek.Length; i++)
            {
                int szam;
                do
                {
                    szam = sorsjegyek[r.Next(sorsjegyek.Length)];
                } while (MarKihuzott(szam, i));

                nyertesek[i] = szam;
            }
        }

        static void EredmenyekKiirasa()
        {
            Console.WriteLine("A tombola nyertesei:");
            for (int i = 0; i < nyeremenyek.Length; i++)
            {
                Console.WriteLine($"{nyertesek[i]}. sorszám: {nyeremenyek[i]}");
            }
        }

        static void Tombola()
        {
            SorsjegyekFeltoltese();
            TombolaSorsolas();
            EredmenyekKiirasa();
        }

        static void Main(string[] args)
        {
            //Feladat6();
            Feladat13();
            Tombola();
        }
    }
}
