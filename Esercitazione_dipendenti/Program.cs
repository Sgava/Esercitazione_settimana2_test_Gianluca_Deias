

using Esercitazione_dipendenti;
using Esercitazione_dipendenti.Aziende;
using Esercitazione_dipendenti.BonusDipendente;

using Esercitazione_dipendenti.PremiDipendente;

FactoryAziende factory = new FactoryAziende();

IAziende azienda = factory.GetAzienda(45);


Console.WriteLine(azienda.GetType());

List<Dipendente> listaDipendenti = new List<Dipendente>()
        {
            new Dipendente("Giorgio","Bianchi",new DateTime(1980,12,4),new DateTime(2010,1,2),3,5),
            new Dipendente("Mario","Rossi",new DateTime(1990,2,27),new DateTime(2012,4,1),80,200),
            new Dipendente("Gavino","Cuccu",new DateTime(1922,12,12),new DateTime(2020,6,15),1000,0),
            new Dipendente("Sandro","Podda",new DateTime(2000,6,4),new DateTime(2020,1,1),2,1)
        };

//foreach (Dipendente dipendente in listaDipendenti)
//{
//    Console.WriteLine(dipendente.StampaDati());
//}

azienda.AggiungiListaAlDB(listaDipendenti);

azienda.VisualizzaDipendenti();

Console.WriteLine("inseirire età massima per ottenere i premi");

 int etaMinima = int.Parse(Console.ReadLine());

Console.WriteLine("inserire produttività minima per ottenere i premi");

int produttivitaMin = int.Parse(Console.ReadLine());  

Console.WriteLine(" inserire Tasso di assenza massimo per ottenere i premi");

int tassoAssenzaMinimo = int.Parse(Console.ReadLine());

IHandlerDipendenti produttività = new ProduttivitaHandler() { EtaMinima=etaMinima, TassoProduttivitàMinimo = tassoAssenzaMinimo};
IHandlerDipendenti presenza = new PresenzaHandler() { EtaMinima = etaMinima, TassoAssenzaMinimo = tassoAssenzaMinimo};
IHandlerDipendenti anzianità = new AnzianitàHandler();
IHandlerDipendenti benessere = new BenessereHandler() { TassoProduttivitàMinimo = tassoAssenzaMinimo};

produttività.SetNext(presenza).SetNext(anzianità).SetNext(benessere);

foreach (Dipendente dipendente in listaDipendenti)
{
    Console.WriteLine(produttività.Handle(dipendente));
}


