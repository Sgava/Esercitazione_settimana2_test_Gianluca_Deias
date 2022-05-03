using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.PremiDipendente
{
    internal class AnzianitàHandler : AbstractHandler
    {
        public override string Handle(BonusDipendente.Dipendente dipendente)
        {
            if (dipendente.CalcolaEta() >= 43)
                return $"Premio Anzianità di Servizio assegnato a {dipendente.Nome} {dipendente.Cognome} ";
            else
                return base.Handle(dipendente);
        }
    }
}
