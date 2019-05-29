using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Program
    {

        static List<Kangelane> Kangelased = new List<Kangelane>();
        static void LaeKangelased(string Failinimi)
        {
            string[] failiAndmed = System.IO.File.ReadAllLines(Failinimi);

            for (int i = 0; i < failiAndmed.Length; i++)
            {
                string[] nimiKoht = failiAndmed[i].Split(new char[] { '/' });
                string nimi = nimiKoht[0].Trim();
                string asukoht = nimiKoht[1].Trim();
                if (nimi.EndsWith("*"))
                {
                   // Kangelased.Add(new SuperKangelane(nimi.Trim(new char[] { '*' }), asukoht));
                } else
                {
                    // Kangelased.Add(new Kangelane(nimi, asukoht));
                }
            }
        }
        static void Main(string[] args)
        {
            HeaKangelane heategelane = new HeaKangelane("Bruce Wayne", "Batman", "Tööriista vöö");
            Console.WriteLine("Vajuta ENTER");
            Console.ReadLine();
            PahaKangelane pahakangelane = new PahaKangelane("", "Joker", "Hullumus");

            heategelane.KasutaV6imet();
            pahakangelane.KasutaV6imet();

            if (heategelane.rynnak() > pahakangelane.rynnak())
            {
                heategelane.V6iduK6ne();
            }
            else
            {
                pahakangelane.V6iduK6ne();
            }


        }
    }
}
