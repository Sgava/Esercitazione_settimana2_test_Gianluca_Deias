using ClassLibrary_Esercitazione_Dipendenti.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Esercitazione_dipendenti_test
{
    public class DecoratorTest
    {

        [Fact]
        public void ShouldHaveEmployeeWithoutBenefit()
        {
            //  i dipendenti che non hanno il bonus non devono avere benefit
            // 

            //ARRANGE

            Dipendente dipendente = new Dipendente() 
            {
                FirstName="Mario",
                LastName="Bianchi"
            };

            //ACT

            string benefit = dipendente.ViewBenefit();

            //ASSERT

            Assert.Equal("", benefit);
            Assert.True(string.IsNullOrEmpty(benefit));
        }


        [Fact]
        public void ShouldHaveCarParkNotFullForEmployee()
        {
            // per i diendenti che hanno il bonus posto auto il codice deve essere diverso da null
            // o stringa vuota

            //ARRANGE

            Dipendente dipendente = new Dipendente();

            dipendente = new DipendenteBonusPostoAuto(dipendente, "abc123");

            //ACT

            //creo il componente i grado di decorare il dipendente con il benefit posto auto
            //

            string benefit = dipendente.ViewBenefit();
            

            //ASSERT

            Assert.True(!string.IsNullOrEmpty(benefit));
            Assert.Contains("abc123", benefit);
            Assert.NotEqual("", benefit);   //valido ma non facilmente comrensibile
            
        }


        [Fact]
        public void ShouldHaveHealthInsurance()
        {
            // per i dipendenti che hanno il bonus posto auto il codice deve essere diverso da null
            // o stringa vuota, lo stesso vale er il codice dell'assistenza

            //ARRANGE

            //creo il dipendente con il benefit del posto auto e dell'assicurazione sanitaria

            Dipendente dipendente = new Dipendente()
            {
                FirstName = "Mario",
                LastName = "Bianchi"
            };

            dipendente = new DipendenteBonusPostoAuto(dipendente, "abc123");

            dipendente = new DipendenteAssistenzaSanitaria(dipendente, "c0d1ce");

            //ACT

            //Visualizzo i benefit
            //

            string benefit = dipendente.ViewBenefit();


            //ASSERT

            Assert.True(!string.IsNullOrEmpty(benefit));
            Assert.Contains("abc123 c0d1ce", benefit);
            Assert.NotEqual("", benefit);   //valido ma non facilmente comrendibile

        }

        [Fact]
        public void ShouldHaveRestaurantTicketsAndInsurance()
        {
            // per i diendenti che hanno il bonus Assicurazione Sanitaria e i buoni per il ristorante


            //ARRANGE

            //creo il dipendente base e gli assegno il bonus Assicurazione Sanitaria e i buoni per il ristorante

            Dipendente dipendente = new Dipendente()
            {
                FirstName = "Mario",
                LastName = "Bianchi"
            };

            dipendente = new DipendenteBonusRestaurantTickets(dipendente, "te55er4", 50);

            dipendente = new DipendenteAssistenzaSanitaria(dipendente, "c0d1ce");

            //ACT

            //creo il componente i grado di decorare il dipendente con il benefit posto auto
            //

            string benefit = dipendente.ViewBenefit();


            //ASSERT

            Assert.True(!string.IsNullOrEmpty(benefit));
            Assert.Contains("abc123 c0d1ce", benefit);
            Assert.NotEqual("", benefit);   //valido ma non facilmente comrendibile

        }


    }
}
