using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethod;

namespace Kolokwium_12022020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piosenka> Playlista = new List<Piosenka>();
            TimeSpan date1 = new TimeSpan(2,3,4);
            TimeSpan date2 = new TimeSpan(4, 5, 6);
            TimeSpan date3 = new TimeSpan(7, 8, 4);
            Playlista.Add(new Piosenka("Ala", "Brzechwa", date1));
            Playlista.Add(new Piosenka("Ola", "Henryk", date2));
            Playlista.Add(new Piosenka("Bolo", "Tuwim", date3));
            Console.WriteLine("Twoja Playlista to:");
            foreach (var i in Playlista)
            {
                Console.WriteLine($"{i.Autor} {i.Tytul} {i.Dlugosc}");
            }
            foreach(var i in Playlista)
            {
                Console.WriteLine($"Dlugosc playlisty {i.Dlugosc.Duration()}");
            }
            var alfatyt = Playlista.OrderBy(x => x.Tytul).ToList();
            var alfaaut = Playlista.OrderBy(x => x.Autor).ToList();
        }
    }
}
