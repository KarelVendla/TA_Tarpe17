using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    abstract class PahaKangelane : Kangelane
    {
        public PahaKangelane(string nimi, string superNimi, string v6ime) : base(nimi, superNimi, v6ime)
        {

        }
    }
}
