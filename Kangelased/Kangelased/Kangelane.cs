using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    abstract class Kangelane
    {
        private string nimi;

        private string asukoht;

        private string superNimi;

        private string v6ime;

        public Kangelane(string nimi,string superNimi, string v6ime)
        {
            this.superNimi = superNimi;
            this.v6ime = v6ime;
            this.nimi = nimi;
        }

        public Kangelane(string nimi, string asukoht)
        {
            this.nimi = nimi;
            this.asukoht = asukoht;
        }

        public string Nimi { get => nimi; set => nimi = value; }
        public string Asukoht { get => asukoht; set => asukoht = value; }
        public string SuperNimi { get => superNimi; set => superNimi = value; }
        public string V6ime { get => v6ime; set => v6ime = value; }

        public virtual int Päästa(int ohus)
        {
            return (int)Math.Round(ohus*.95);
        }

        public string AnnaNimi()
        {
            return Nimi;
        }

        public string AnnaSuperNimi()
        {
            return SuperNimi;
        }

        public string AnnaV6ime()
        {
            return V6ime;
        }


        public abstract void V6iduK6ne();

        public override string ToString()
        {
            return Nimi + " hoiab " + Asukoht + " turvalisena .";
        }
    }
}
