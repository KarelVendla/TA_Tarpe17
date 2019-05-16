using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class PahaKangelane : Kangelane
    {
        public PahaKangelane(string nimi, string superNimi, string v6ime) : base(nimi, superNimi, v6ime)
        {

        }

        public string KasutaV6imet()
        {
            return "Paha kangelane " + AnnaSuperNimi() + " püüab hävitada maailma.";
        }

        public override void V6iduK6ne()
        {
            Console.WriteLine("Tänaseks aitab.");
        }
    }
}
