using Esercitazione_dipendenti.BonusDipendente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.PremiDipendente
{
    public class BenessereHandler : AbstractHandler
    {
        public int TassoProduttivitàMinimo { get; set; }
        public override string Handle(Dipendente dipendente)
        {
            if (dipendente.TassoDiProduttivita >= TassoProduttivitàMinimo)
                return $"Premio Benessere collettivo assegnato a {dipendente.Nome} {dipendente.Cognome} ";
            else
                return base.Handle(dipendente);
        }
    }
}
