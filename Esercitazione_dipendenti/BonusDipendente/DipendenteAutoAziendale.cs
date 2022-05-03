using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.BonusDipendente
{
    internal class DipendenteAutoAziendale : DipendenteDecorator
    {
        public string NumeroTarga { get; set; }
        public string Modello { get; set; }

        public DipendenteAutoAziendale(Dipendente dipendente, string numTarga, string modello) : base(dipendente)
        {
            NumeroTarga = numTarga;
            Modello = modello;
        }
    }
}
