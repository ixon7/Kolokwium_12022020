using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_12022020
{
    class Cytat
    {
        //var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
        public string Author { get; set; }
        public string Tytul { get; set; }
        public static DateTime DataWydania { get; set; }
        public string Wydawnictwo { get; set; }

        public void Deconstruct(out string author, out DataTime dataWydania)
        {
            author = Author;
            dataWydania = DataWydania;
        }
        public void Deconstruct(out string tytul, out string nazwisko, out string miejsce, out string wydawinictwo, out DataTime dataWydania)
        {
            tytul = Tytul;
            nazwisko = Author.Substring(2,5);
            miejsce = Wydawnictwo;
            wydawinictwo = Wydawnictwo;
            dataWydania = DataWydania;
        }
    }
}
