using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_12022020
{
    class Kopiarka : IKopiarka
    {
        public string Drukuj()
        {
            throw new NotImplementedException();
        }

        public void Drukuj(string d)
        {
            throw new NotImplementedException();
        }

        public string Kopiuj(string notnull)
        {
            return Skanuj();
        }

        public string Skanuj()
        {
            throw new NotImplementedException();
        }
    }
}
