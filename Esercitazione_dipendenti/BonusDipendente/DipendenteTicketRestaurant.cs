using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.BonusDipendente
{
    internal class DipendenteTicketRestaurant : DipendenteDecorator
    {
        public string NumeroTarga { get; set; }
        public int NumeroTicketMensili { get; set; }

        public DipendenteTicketRestaurant(Dipendente dipendente, string numTarga, int numTicket) : base(dipendente)
        {
            NumeroTarga = numTarga;
            NumeroTicketMensili = numTicket;
        }
    }
}
