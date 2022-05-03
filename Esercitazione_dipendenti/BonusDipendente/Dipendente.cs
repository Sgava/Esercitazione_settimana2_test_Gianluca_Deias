using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_dipendenti.BonusDipendente
{
    public class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }

        public DateTime DataDiAssunzione { get; set; }

        public int TassoDiProduttivita { get; set; }

        public int TassoDiAssenza { get; set; }

        public Dipendente() { }

        public Dipendente(string nome, string cognome, DateTime dataDiNascita, DateTime dataDiAssunzione)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            DataDiAssunzione = dataDiAssunzione;

        }

        public Dipendente(string nome, string cognome, DateTime dataDiNascita, DateTime dataDiAssunzione, int tassoProduttivita, int tassoDiAssenza)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            DataDiAssunzione = dataDiAssunzione;
            TassoDiProduttivita = tassoProduttivita;
            TassoDiAssenza = tassoDiAssenza;

        }

        public string StampaDati()
        {
            return $" {Nome} {Cognome}";
        }

        public int CalcolaEta()
        {
            DateTime DataDiOggi = DateTime.Now;
            var età = DataDiOggi.Year - DataDiNascita.Year;
            return età;
        }

        public int CalcolaAnniServizio()
        {
            DateTime DataDiOggi = DateTime.Now;
            var anniServizio = DataDiOggi.Year - DataDiAssunzione.Year;
            return anniServizio;
        }


        private static void CreaDipendente()
        {
            Console.WriteLine("\nInserisci il Nome del dipendente\n");

            string nomeDipendente = Console.ReadLine();

            Console.WriteLine("\nInserisci il Nome del dipendente\n");

            string cognomeDipendente = Console.ReadLine();




            Console.WriteLine("\nInserisci il giorno della data di nascita");

            int giorno;

            while (!(int.TryParse(Console.ReadLine(), out giorno) && giorno >= 1 && giorno <= 31))
            {
                Console.WriteLine("Riprova, inserimento giorno non riuscito");
            }

            Console.WriteLine("\nInserisci il mese della data di nascita");

            int mese;

            while (!(int.TryParse(Console.ReadLine(), out mese) && mese >= 1 && mese <= 12))
            {
                Console.WriteLine("Riprova, inserimento mese non riuscito");
            }

            Console.WriteLine("\nInserisci l'anno di nascita");

            int anno;

            while (!int.TryParse(Console.ReadLine(), out anno))
            {
                Console.WriteLine("\nRiprova, inserimento giorno non riuscito");
            }

            var dataDiNascita = new DateTime(anno, mese, giorno);



            Console.WriteLine("\nInserisci il giorno della data di assunzione");



            while (!(int.TryParse(Console.ReadLine(), out giorno) && giorno >= 1 && giorno <= 31))
            {
                Console.WriteLine("Riprova, inserimento giorno non riuscito");
            }

            Console.WriteLine("\nInserisci il mese della data di assunzione");



            while (!(int.TryParse(Console.ReadLine(), out mese) && mese >= 1 && mese <= 12))
            {
                Console.WriteLine("Riprova, inserimento mese non riuscito");
            }

            Console.WriteLine("\nInserisci l'anno di assunzione");



            while (!int.TryParse(Console.ReadLine(), out anno))
            {
                Console.WriteLine("\nRiprova, inserimento giorno non riuscito");
            }

            var dataDiAssunzione = new DateTime(anno, mese, giorno);




            var nuovoDipendente = new Dipendente(nomeDipendente, cognomeDipendente, dataDiNascita, dataDiAssunzione);

            // var esito = AggiungiDipendenteAllaLista(nuovoDipendente);

        }
    }
}
