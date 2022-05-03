using ClassLibrary_Esercitazione_Dipendenti.Entities;

namespace ClassLibrary_Esercitazione_Dipendenti.Chain
{
    public class AbsenceHandler : IHandler
    {
        public IHandler _nextHandler;

        public int y { get; set; }
        public int z { get; set; }

        public AbsenceHandler(int y, int z)
        {
            this.y = y;
            this.z = z;
        }

        public double HandleRequest(Dipendente dipendente)
        {
            if (dipendente.Age < y && dipendente.Absence <= z)
                return 200.0;
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