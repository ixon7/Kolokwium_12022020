using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_12022020
{
    interface IKopiarka : ISkaner, IDrukarka
    {
        new string Skanuj();
        new string Drukuj();
        string Kopiuj(string notnull);
    }
}
