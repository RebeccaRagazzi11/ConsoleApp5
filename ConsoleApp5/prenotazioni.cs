using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class prenotazioni
    {
        public DateTime dataprenotazione { get; set; }
        public int numeroprogressivo  { get; set; }
        public int anno { get; set; }
        public DateTime dalgiorno { get; set; }
        public DateTime algiorno { get; set; }
        public float caparra { get; set; }
        public float tariffa { get; set; } 
        public Servizi serviziaggiuntivi { get; set; } 

    }
}

