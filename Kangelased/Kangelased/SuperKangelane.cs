using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class SuperKangelane : Kangelane
    {
        private double osavus;

        public SuperKangelane(string Nimi, string Asukoht):base(Nimi,Asukoht)
        {
            Random r = new Random();
            osavus = r.Next(1, 5) + r.NextDouble();
        }

        public override int Päästa(int ohus)
        {
            return (int)Math.Round(ohus * (95 + osavus) / 100);
        }

        public override string ToString()
        {
            return base.ToString() + "ja ta on selles " + osavus + "protsenti osavam kui teised.";
        }
    }
}
