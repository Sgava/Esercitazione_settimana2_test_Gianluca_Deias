using Esercitazione_dipendenti.BonusDipendente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.PremiDipendente
{
    internal class PresenzaHandler : AbstractHandler
    {
        public int TassoAssenzaMinimo { get; set; }
        public int EtaMinima { get; set; }

        public override string Handle(Dipendente dipendente)
        {
            if (dipendente.TassoDiAssenza <= TassoAssenzaMinimo && dipendente.CalcolaEta() <= EtaMinima)
                return $"Premio produttivo assegnato a {dipendente.Nome} {dipendente.Cognome} ";
            else
                return base.Handle(dipendente);
        }
    }
}
