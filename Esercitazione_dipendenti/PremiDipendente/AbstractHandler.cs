using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.PremiDipendente
{
    public abstract class AbstractHandler : IHandlerDipendenti
    {
        private IHandlerDipendenti _nextHandler;
        public virtual string Handle(BonusDipendente.Dipendente dipendente)
        {
            if (_nextHandler != null)

                return _nextHandler.Handle(dipendente);
            else

                Console.WriteLine("nessun premio assegnato");
            return null;
        }

        public IHandlerDipendenti SetNext(IHandlerDipendenti handler)
        {
            _nextHandler = handler;
            return handler;
        }
    }
}
