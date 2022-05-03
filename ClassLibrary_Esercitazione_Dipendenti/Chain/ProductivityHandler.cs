using ClassLibrary_Esercitazione_Dipendenti.Entities;

namespace ClassLibrary_Esercitazione_Dipendenti.Chain
{
    public class ProductivityHandler : IHandler
    {
        private int y;
        private int w;

        public IHandler _nextHandler;

        public ProductivityHandler(int y, int w)
        {
            this.y = y;
            this.w = w;
        }

        public double HandleRequest(Dipendente dipendente)
        {
            if (dipendente.Age < y && dipendente.Productivity >= w)
                return 300.0;
            else
                return _nextHandler.HandleRequest(dipendente);
        }

        public static void SetNext(AbsenceHandler absenceHandler)
        {
            throw new NotImplementedException();
        }

        public IHandler SetNext(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return _nextHandler;
        }
    }
}