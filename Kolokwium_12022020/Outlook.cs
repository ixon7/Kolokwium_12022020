using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_12022020
{
    class Outlook :Poczta
    {
        public string Author { get; set; }
        public string Wiadomosc { get; set; }

        public void Send(object sender, EventArgs e)
        {
            Console.WriteLine("Author" + "");
        }
    }
}
