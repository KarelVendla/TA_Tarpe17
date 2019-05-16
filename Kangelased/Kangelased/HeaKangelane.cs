using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class HeaKangelane : Kangelane
    {
        private string nimi;

        public HeaKangelane(string nimi, string superNimi, string v6ime) : base(nimi, superNimi, v6ime)
        {
        }

        public string KasutaV6imet()
        {
            return "Hea kangelane " + AnnaSuperNimi() + " päästab maailma.";
        }

        public override void V6iduK6ne()
        {
            Console.WriteLine("Pelmeen!");
        }
    }
}
