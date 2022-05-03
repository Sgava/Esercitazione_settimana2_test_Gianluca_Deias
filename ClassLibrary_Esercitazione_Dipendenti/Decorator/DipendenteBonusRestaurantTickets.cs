using ClassLibrary_Esercitazione_Dipendenti.Entities;

namespace ClassLibrary_Esercitazione_Dipendenti.Decorator
{
    public class DipendenteBonusRestaurantTickets : DipendenteAbstractDecorator
    {

        public string CodiceRistorante { get; set; }   
        public int NumeroTickets { get; set; }  


        public DipendenteBonusRestaurantTickets(Dipendente dipendente, string codice, int numTickets) : base(dipendente)
        {
           CodiceRistorante = codice;
            NumeroTickets = numTickets;
            
        }

        public override string ViewBenefit()
        {
            return DipendenteDiPartenza.ViewBenefit() + $" {CodiceRistorante} {NumeroTickets}";
        }
    }
}