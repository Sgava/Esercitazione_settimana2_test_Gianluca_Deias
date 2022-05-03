using ClassLibrary_Esercitazione_Dipendenti.Entities;

namespace ClassLibrary_Esercitazione_Dipendenti.Chain
{
    public interface IHandler
    {
        double HandleRequest(Dipendente dipendente);
        IHandler SetNext(IHandler nextHandler);
    }
}