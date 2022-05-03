using Esercitazione_dipendenti.BonusDipendente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.Aziende
{
    public interface IAziende
    {

        public int NumeroDipendenti { get; set; }

        static List<Dipendente> listaDipendenti = new List<Dipendente>();

        bool AggiungiDipendenteAllaLista(Dipendente dip);

        void AggiungiListaAlDB(List<Dipendente> lista);

        void VisualizzaDipendenti();


    }
}
