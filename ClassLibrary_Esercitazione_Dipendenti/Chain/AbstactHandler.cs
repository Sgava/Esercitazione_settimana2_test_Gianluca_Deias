using ClassLibrary_Esercitazione_Dipendenti.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Esercitazione_Dipendenti.Chain
{
    internal class AbstactHandler : IHandler
    {

        public IHandler _nextHandler;

        public double HandleRequest(Dipendente dipendente)
        {
            if (_nextHandler != null)

                return _nextHandler.HandleRequest(dipendente);
            else

                Console.WriteLine("nessun premio assegnato");
            return 0.0;
        }

        public IHandler SetNext(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return _nextHandler;
        }
    }
}
