using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.BonusDipendente;

internal class DipendenteAssicurazioneSanitaria : DipendenteDecorator
{
    public string CodiceCliente { get; set; }

    public DipendenteAssicurazioneSanitaria(Dipendente dipendente, string codCliente) : base(dipendente)
    {
        CodiceCliente = codCliente;
    }
}
