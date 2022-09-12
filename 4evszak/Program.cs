using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4evszak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem írja be egy hónap számát(1-12): ");
            int honapszam = 0;
            int helytelen = 0;
            string megoldas = "";
            int[] honapokszama = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            do
            {
                if (helytelen > 0)
                {
                    Console.WriteLine("Kérem egész számot írjon be! \nHónap száma(1-12):");
                }
                helytelen++;
            }
            while (!int.TryParse(Console.ReadLine(), out honapszam) || honapszam > 12 || honapszam < 1);
            if (honapszam == honapokszama[0] || honapszam == honapokszama[1] || honapszam == honapokszama[11])
            {megoldas = "Téli évszak";}
            else if (honapszam == honapokszama[2] || honapszam == honapokszama[3] || honapszam == honapokszama[4])
            {megoldas = "Tavaszi évszak";}
            else if (honapszam == honapokszama[5] || honapszam == honapokszama[6] || honapszam == honapokszama[7])
            {megoldas = "Nyári évszak";}
            else if (honapszam == honapokszama[8] || honapszam == honapokszama[9] || honapszam == honapokszama[10])
            {megoldas = "Őszi évszak";}

            Console.WriteLine($"A megadott szám {megoldas}hoz tartozik");
            Console.ReadKey();
        }
    }
}
