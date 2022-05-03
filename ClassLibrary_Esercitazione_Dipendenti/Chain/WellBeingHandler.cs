using ClassLibrary_Esercitazione_Dipendenti.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Esercitazione_Dipendenti.Chain
{
    public class WellBeingHandler : IHandler
    {
        public IHandler _nextHandler;

        private int w;

        public WellBeingHandler(int w)
        {
            this.w = w;
        }

        public double HandleRequest(Dipendente dipendente)
        {
            if (dipendente.Productivity >= w)
                return 175.0;
            else
                return _nextHandler.HandleRequest(dipendente);
        }

        public IHandler SetNext(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return _nextHandler;
        }
    }
}
