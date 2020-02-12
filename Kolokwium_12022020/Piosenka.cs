using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_12022020
{
    class Piosenka
    {
        public Piosenka(string tytul, string autor, TimeSpan dlugosc)
        {
            Tytul = tytul;
            Autor = autor;
            Dlugosc = dlugosc;
        }

        public string Tytul { get; set; }
        public string Autor { get; set; }
        public TimeSpan Dlugosc { get; set; }

    }
}
