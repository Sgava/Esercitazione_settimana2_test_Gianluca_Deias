using ClassLibrary_Esercitazione_Dipendenti.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Esercitazione_Dipendenti.Chain
{
    public class ElderlyHandle : IHandler
    {
        public IHandler _nextHandler;


        public double HandleRequest(Dipendente dipendente)
        {
            if (dipendente.YearsOfService > 43)
                return 150.0;
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
