using Esercitazione_dipendenti.Aziende;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti
{
    internal class FactoryAziende
    {
        public IAziende GetAzienda(int numDipendenti)
        {
            IAziende azienda = null;
            if (numDipendenti <= 0)
                return null;

            switch (numDipendenti)
            {
                case int n when n <= 20:
                    azienda = new PiccolaAzienda() { NumeroDipendenti = numDipendenti };
                    break;
                case int n when n <= 100:
                    azienda = new MediaAzienda() { NumeroDipendenti = numDipendenti };
                    break;
                case int n when n <= 500:
                    azienda = new GrandeAzienda() { NumeroDipendenti = numDipendenti };
                    break;
                default:
                    azienda = new Multinazionale() { NumeroDipendenti = numDipendenti };
                    break;

            }
            return azienda;
        }

    }
}
