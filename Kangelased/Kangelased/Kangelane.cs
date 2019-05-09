using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelane
    {
        private string nimi;

        private string asukoht;

        public Kangelane(string nimi, string asukoht)
        {
            this.Nimi = nimi;
            this.Asukoht = asukoht;
        }

        public string Nimi { get => nimi; set => nimi = value; }
        public string Asukoht { get => asukoht; set => asukoht = value; }


        public static int Päästa(int ohus)
        {
            return (int)Math.Round(ohus*.95);
        }

        public override string ToString()
        {
            return Nimi + " hoiab " + Asukoht + " turvalisena .";
        }
    }
}
