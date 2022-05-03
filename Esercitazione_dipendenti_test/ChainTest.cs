using ClassLibrary_Esercitazione_Dipendenti.Entities;
using ClassLibrary_Esercitazione_Dipendenti.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Esercitazione_dipendenti_test
{
    public class ChainTest
    {
        [Fact]
        public void ShouldHaveProductivityAwardAge20Productivity50()
        {
            // mi aspetto che un dipendente di 20 anni e produttività del 50%
            // ottenga 300€ con valori di Y = 25  e W=40

            //ARRANGE

            Dipendente dipendente = new Dipendente()
            {
                DateOfBirth = new DateTime(2007, 1,1),
                Productivity = 50
            };

            //creo il gestore della richiesta

            int y = 25;
            int w = 40;

            IHandler productivityHanlder = new ProductivityHandler(y, w);

            //ACT

            double premio = productivityHanlder.HandleRequest(dipendente);

            //ASSERT

            //verifico che il remio sia uguale a 300

            Assert.Equal(300, premio);



            
        }


        [Fact]
        public void ShouldHavePresenceAwardAge20Absence30()
        {
            // mi aspetto che un dipendente di 30 anni e assenza del 50%
            // ottenga 200€ con valori di Y = 35  e Z=55

            //ARRANGE

            Dipendente dipendente = new Dipendente()
            {
                DateOfBirth = new DateTime(1993, 1, 1),
                Absence = 30
            };

            //creo il gestore della richiesta

            int y = 35;
            int z = 55;

            IHandler absenceHanlder = new AbsenceHandler(y, z);

            //ACT

            double premio = absenceHanlder.HandleRequest(dipendente);

            //ASSERT

            //verifico che il premio sia uguale a 200

            Assert.Equal(200, premio);




        }


        [Fact]
        public void ShouldHaveProductivityAwardFirstAndAbsenceAward()
        {
            // mi aspetto che un dipendente con i requisiti er tutti e due i premi vinca
            //vinca solo il primo che verifica le condizioni (produttivita)

            //ARRANGE

            Dipendente dipendente = new Dipendente()
            {
                DateOfBirth = new DateTime(2007, 1, 1),
                Productivity = 50,
                Absence = 30
            };

            //creo il gestore della richiesta

            int y = 25;
            int w = 40;
            int z = 55;

            //genero la chain of responsability

            IHandler productivityHandler = new ProductivityHandler(y, w);
            IHandler absenceHandler = new AbsenceHandler(y, z);

            productivityHandler.SetNext(absenceHandler);

            //ACT

            double premio = productivityHandler.HandleRequest(dipendente);

            //ASSERT

            //verifico che il premio sia uguale a 300

            Assert.Equal(300, premio);




        }


        [Fact]
        public void ShouldHaveAbsenceAwardFirstAndProductivityAward()
        {
            // mi aspetto che un dipendente con i requisiti per tutti e due i premi vinca
            // vinca solo il primo che verifica le condizioni (assenza)

            //ARRANGE

            Dipendente dipendente = new Dipendente()
            {
                DateOfBirth = new DateTime(2007, 1, 1),
                Productivity = 50,
                Absence = 30
            };

            //creo il gestore della richiesta

            int y = 25;
            int w = 40;
            int z = 55;

            //genero la chain of responsability

            IHandler productivityHandler = new ProductivityHandler(y, w);
            IHandler absenceHandler = new AbsenceHandler(y, z);

            absenceHandler.SetNext(productivityHandler);

            //ACT

            double premio = absenceHandler.HandleRequest(dipendente);

            //ASSERT

            //verifico che il premio sia uguale a 200

            Assert.Equal(200, premio);
        }

        [Fact]
        public void ShouldHaveAbsenceAwardFirstAndNotProductivityAward()
        {
            // mi aspetto che un dipendente con i requisiti per solo il premio produttivita 
            // prenda il premio della produttività alla fine della catena 

            //ARRANGE

            Dipendente dipendente = new Dipendente()
            {
                DateOfBirth = new DateTime(2007, 1, 1),
                Productivity = 50,
                Absence = 30
            };

            //creo il gestore della richiesta

            int y = 25;
            int w = 40;
            int z = 25;

            //genero la chain of responsability

            IHandler productivityHandler = new ProductivityHandler(y, w);
            IHandler absenceHandler = new AbsenceHandler(y, z);

            absenceHandler.SetNext(productivityHandler);

            //ACT

            double premio = absenceHandler.HandleRequest(dipendente);

            //ASSERT

            //verifico che il premio sia uguale a 300

            Assert.Equal(300, premio);
        }


        [Fact]
        public void ShouldHaveElderlyBonusAndNothingMore()
        {
            // mi aspetto che un dipendente con i requisiti per solo il premio anzianità 
            // prenda il premio della produttività alla fine della catena 

            //ARRANGE

            Dipendente dipendente = new Dipendente()
            {
                DateOfRecruitment = new DateTime(1975,1,1),
                DateOfBirth = new DateTime(1955, 1, 1),
                Productivity = 1,
                Absence = 90
            };

            //creo il gestore della richiesta

            int y = 25;
            int w = 40;
            int z = 25;

            //genero la chain of responsability

            IHandler productivityHandler = new ProductivityHandler(y, w);
            IHandler absenceHandler = new AbsenceHandler(y, z);
            IHandler elderlyHandler = new ElderlyHandle();

            absenceHandler.SetNext(productivityHandler).SetNext(elderlyHandler);

            //ACT

            double premio = absenceHandler.HandleRequest(dipendente);

            //ASSERT

            //verifico che il premio sia uguale a 150

            Assert.Equal(150, premio);
        }




        [Fact]
        public void ShouldHaveWellBeingBonusAndNothingMore()
        {
            // mi aspetto che un dipendente con i requisiti per solo il premio benessere 
            // prenda il premio della produttività alla fine della catena 

            //ARRANGE

            Dipendente dipendente = new Dipendente()
            {
                DateOfRecruitment = new DateTime(2000, 1, 1),
                DateOfBirth = new DateTime(1990, 1, 1),
                Productivity = 100,
                Absence = 90
            };

            //creo il gestore della richiesta

            int y = 25;
            int w = 40;
            int z = 25;

            //genero la chain of responsability

            IHandler productivityHandler = new ProductivityHandler(y, w);
            IHandler absenceHandler = new AbsenceHandler(y, z);
            IHandler elderlyHandler = new ElderlyHandle();
            IHandler wellBeingHandler = new WellBeingHandler(w);

            absenceHandler.SetNext(productivityHandler).SetNext(elderlyHandler).SetNext(wellBeingHandler);

            //ACT

            double premio = absenceHandler.HandleRequest(dipendente);

            //ASSERT

            //verifico che il premio sia uguale a 175

            Assert.Equal(175.0, premio);
        }
    }
}
