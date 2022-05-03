using Esercitazione_dipendenti.BonusDipendente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.Aziende
{
    public class Multinazionale : IAziende
    {
        public int NumeroDipendenti { get; set; }

        public static List<Dipendente> listaDipendenti = new List<Dipendente>();

        public bool AggiungiDipendenteAllaLista(Dipendente dip)
        {
            if (dip == null)
                return false;
            listaDipendenti.Add(dip);
            return true;
        }

        public void AggiungiListaAlDB(List<Dipendente> lista)
        {
            listaDipendenti.AddRange(lista);
        }

        public void VisualizzaDipendenti()
        {


            if (listaDipendenti.Count == 0)
            {
                Console.WriteLine("\nNon sono presenti dipendenti\n");
            }
            else
            {
                Console.WriteLine("lista dipendenti \n");
                foreach (var dipendente in listaDipendenti)
                {
                    Console.WriteLine($"{dipendente.Nome} {dipendente.Cognome}");
                }
            }
        }
    }
}
