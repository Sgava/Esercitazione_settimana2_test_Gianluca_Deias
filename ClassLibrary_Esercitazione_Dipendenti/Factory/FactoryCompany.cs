using ClassLibrary_Esercitazione_Dipendenti.Entities;
using System;

namespace ClassLibrary_Esercitazione_Dipendenti.Factory
{
    public class FactoryCompany
    {
        public FactoryCompany()
        {
        }

        public ICompany CreateCompany(int numDipendenti)
        {
            ICompany company = null;

            if (numDipendenti > 0 && numDipendenti <= 20) return company = new SmallCompany();

            else if (numDipendenti > 20 && numDipendenti <= 100) return company = new MediumCompany();

            else if (numDipendenti > 100 && numDipendenti < 500) return company = new LargeCompany();

            else if (numDipendenti >= 500) return new Multinational();

            return company;

        }
    }
}