using Esercitazione_dipendenti.BonusDipendente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.PremiDipendente;

public interface IHandlerDipendenti
{

    IHandlerDipendenti SetNext(IHandlerDipendenti handler);

    string Handle(Dipendente dipendente);
}
