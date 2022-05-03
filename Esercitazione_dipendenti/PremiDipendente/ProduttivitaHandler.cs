﻿using Esercitazione_dipendenti.BonusDipendente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.PremiDipendente
{
    internal class ProduttivitaHandler : AbstractHandler
    {
        public int TassoProduttivitàMinimo { get; set; }
        public int EtaMinima { get; set; }

        public override string Handle(Dipendente dipendente)
        {
            if (dipendente.TassoDiProduttivita >= TassoProduttivitàMinimo && dipendente.CalcolaEta() <= EtaMinima)
                return $"Premio produttivo assegnato a {dipendente.Nome} {dipendente.Cognome} ";
            else
                return base.Handle(dipendente);
        }

    }
}
