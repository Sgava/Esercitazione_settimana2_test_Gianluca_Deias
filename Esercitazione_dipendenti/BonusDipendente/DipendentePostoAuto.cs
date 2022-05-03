using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.BonusDipendente
{
    public class DipendentePostoAuto : DipendenteDecorator
    {
        public string CodicePostoAuto { get; set; }

        public DipendentePostoAuto(Dipendente dipendente, string codPosto) : base(dipendente)
        {
            CodicePostoAuto = codPosto;
        }
    }
}
