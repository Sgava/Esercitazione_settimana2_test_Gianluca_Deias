using ClassLibrary_Esercitazione_Dipendenti.Entities;

namespace Esercitazione_dipendenti_test
{
    internal class DipendenteBonusRestaurantTickets : Dipendente
    {
        private Dipendente dipendente;
        private string v;

        public DipendenteBonusRestaurantTickets(Dipendente dipendente, string v)
        {
            this.dipendente = dipendente;
            this.v = v;
        }
    }
}