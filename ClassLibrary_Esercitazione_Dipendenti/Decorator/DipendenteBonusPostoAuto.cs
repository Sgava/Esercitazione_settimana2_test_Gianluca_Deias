using ClassLibrary_Esercitazione_Dipendenti.Entities;

namespace ClassLibrary_Esercitazione_Dipendenti.Decorator
{
    public class DipendenteBonusPostoAuto : DipendenteAbstractDecorator
    {

        public string codicePostoAuto { get; set; }

        public DipendenteBonusPostoAuto(Dipendente dipendente, string codice) : base(dipendente)
        {

            codicePostoAuto = codice;
        }

        public override string ViewBenefit()
        {
            return DipendenteDiPartenza.ViewBenefit() + $" {codicePostoAuto}";
        }
    }
}