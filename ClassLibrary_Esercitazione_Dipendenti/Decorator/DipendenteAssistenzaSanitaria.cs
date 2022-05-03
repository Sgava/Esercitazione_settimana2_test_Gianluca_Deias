using ClassLibrary_Esercitazione_Dipendenti.Entities;

namespace ClassLibrary_Esercitazione_Dipendenti.Decorator
{
    public class DipendenteAssistenzaSanitaria : DipendenteAbstractDecorator
    {

        public string CodiceCliente { get; set; }

        public DipendenteAssistenzaSanitaria(Dipendente dipendente, string codice) : base(dipendente)
        {

            CodiceCliente = codice;
        }

        public override string ViewBenefit()
        {
            return DipendenteDiPartenza.ViewBenefit() + $" {CodiceCliente}";
        }
    }
}