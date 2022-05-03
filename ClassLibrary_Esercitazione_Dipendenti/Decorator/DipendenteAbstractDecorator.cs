using ClassLibrary_Esercitazione_Dipendenti.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Esercitazione_Dipendenti.Decorator
{
    public class DipendenteAbstractDecorator : Dipendente
    {
        public Dipendente DipendenteDiPartenza { get; set; }

        public DipendenteAbstractDecorator(Dipendente dipendente)
        {
            DipendenteDiPartenza = dipendente;
        }

        public override string ViewBenefit()
        {
            return base.ViewBenefit();
        }
    }
}
