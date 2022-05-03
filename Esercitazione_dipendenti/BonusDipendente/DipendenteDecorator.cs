using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.BonusDipendente
{
    public class DipendenteDecorator : Dipendente
    {
        public Dipendente promotoreDipendente { get; set; }

        public DipendenteDecorator(Dipendente dipendente)
        {
            promotoreDipendente = dipendente;
        }

    }
}
