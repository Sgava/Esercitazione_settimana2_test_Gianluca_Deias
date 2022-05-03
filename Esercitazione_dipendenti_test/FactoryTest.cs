using ClassLibrary_Esercitazione_Dipendenti.Entities;
using ClassLibrary_Esercitazione_Dipendenti.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Esercitazione_dipendenti_test
{
    public class FactoryTest
    {
        [Fact]
        public void ShouldCreateNullCompanyWithNegativeEmployees()
        {
            // mi aspetto la creazione di una PiccolaAzienda nel caso di pochi dipendenti

            //ARRANGE

            // dichiaro una variabile con il numero dei dipendenti

            int numDipendenti = -2;

            //richiamo il componente che creerà la company

            FactoryCompany factoryCompany = new FactoryCompany();

            //ACT

            //richiamo il metodo di creazione azienda

            ICompany nullCompany = factoryCompany.CreateCompany(numDipendenti);

            //ASSERT

            Assert.Null(nullCompany);
        }

        
        [Fact]

        public void ShouldCreatePiccolaAzienda()
        {
            // mi aspetto la creazione di una PiccolaAzienda nel caso di pochi dipendenti

            //ARRANGE

            // dichiaro una variabile con il numero dei dipendenti

            int numDipendenti = 10;

            //richiamo il componente che creerà la company

            FactoryCompany factoryCompany = new FactoryCompany();

            //ACT

            //richiamo il metodo di creazione azienda

            ICompany smallCompany = factoryCompany.CreateCompany(numDipendenti);

            //ASSERT

            Assert.Equal("SmallCompany",smallCompany.GetType().Name);

        }

        [Fact]
        public void ShouldCreateMediumCompany()
        {
            // mi aspetto la creazione di una PiccolaAzienda nel caso di pochi dipendenti

            //ARRANGE

            // dichiaro una variabile con il numero dei dipendenti

            int numDipendenti = 50;

            //richiamo il componente che creerà la company

            FactoryCompany factoryCompany = new FactoryCompany();

            //ACT

            //richiamo il metodo di creazione azienda

            ICompany mediumCompany = factoryCompany.CreateCompany(numDipendenti);

            //ASSERT

            Assert.Equal("MediumCompany", mediumCompany.GetType().Name);

        }

        [Fact]
        public void ShouldCreateLargeCompany()
        {
            // mi aspetto la creazione di una grande Azienda nel caso di molti dipendenti

            //ARRANGE

            // dichiaro una variabile con il numero dei dipendenti

            int numDipendenti = 400;

            //richiamo il componente che creerà la company

            FactoryCompany factoryCompany = new FactoryCompany();

            //ACT

            //richiamo il metodo di creazione azienda

            ICompany largeCompany = factoryCompany.CreateCompany(numDipendenti);

            //ASSERT

            Assert.Equal("LargeCompany", largeCompany.GetType().Name);

        }

        [Fact]
        public void ShouldCreateMultinational()
        {
            // mi aspetto la creazione di una multinazionale nel caso di 500+ dipendenti

            //ARRANGE

            // dichiaro una variabile con il numero dei dipendenti

            int numDipendenti = 600;

            //richiamo il componente che creerà la company

            FactoryCompany factoryCompany = new FactoryCompany();

            //ACT

            //richiamo il metodo di creazione azienda

            ICompany multinational = factoryCompany.CreateCompany(numDipendenti);

            //ASSERT

            Assert.Equal("Multinational", multinational.GetType().Name);

        }

    }
}
