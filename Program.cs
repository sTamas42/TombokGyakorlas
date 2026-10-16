using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace TombokGyakorlas
{
    internal class Program
    {

        static int[] tomb = new int[5];
    static void Feladat6()
        {
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

        }
        static void Main(string[] args)
        {
            Feladat6();
            Feladat13();
        }
    }
}
