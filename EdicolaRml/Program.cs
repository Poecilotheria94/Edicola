using System.Collections.Generic;

namespace EdicolaRml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pubblicazione> listaPubblicazioni = new List<Pubblicazione>();

            bool ins = true;


            while (ins)
            {
                Console.WriteLine("Cosa vuoi aggiungere?\nPremi A per inserire un giornale\nPremi B per inserire una rivista\nPremi C per rimuovere una pubblicazione\nPremi Z per uscire ");
                string inputUser = Console.ReadLine(); 

                switch (inputUser.ToLower())
                {
                    case "a":
                        Console.WriteLine("Inserisci il codice:");
                        string codice = Console.ReadLine().Trim();

                        Console.WriteLine("Inserisci il prezzo:");
                        string prezzoRaw = Console.ReadLine();

                        float prezzo = float.Parse(prezzoRaw);

                        if (!float.TryParse(prezzoRaw, out prezzo))
                        {
                            Console.WriteLine("Il prezzo inserito non è valido. Assicurati di inserire un numero.");
                            continue;
                        }

                        Console.WriteLine("Inserisci la redazione:");
                        string redazione = Console.ReadLine();

                        listaPubblicazioni.Add(new Giornale(codice, prezzo, redazione, true));

                        Console.WriteLine($"Complimenti il giornale con il codice {codice} è stato inserito!");
                        break;

                    case "b":
                        Console.WriteLine("Inserisci il codice:");
                        codice = Console.ReadLine().Trim();

                        Console.WriteLine("Inserisci il prezzo:");
                        prezzoRaw = Console.ReadLine(); 

                        if (!float.TryParse(prezzoRaw, out prezzo))
                        {
                            Console.WriteLine("Il prezzo inserito non è valido. Assicurati di inserire un numero.");
                            continue; 
                        }

                        Console.WriteLine("Inserisci il titolo:");
                        string titolo = Console.ReadLine();

                        Console.WriteLine("Inserisci la categoria:");
                        string categoria = Console.ReadLine();

                        listaPubblicazioni.Add(new Rivista(codice, prezzo, titolo, categoria));

                        Console.WriteLine($"Complimenti {titolo} con il codice {codice} è stata inserita!");
                        break;


                    case "c":
                        Console.WriteLine("Inserisci il codice della pubblicazione da rimuovere:");

                        string codiceDaRimuovere = Console.ReadLine();

                        Pubblicazione pubblicazioneDaRimuovere = listaPubblicazioni.Find(p => p.Codice == codiceDaRimuovere);

                        if (pubblicazioneDaRimuovere != null)
                        {
                            listaPubblicazioni.Remove(pubblicazioneDaRimuovere);
                            Console.WriteLine($"Pubblicazione con codice {codiceDaRimuovere} rimossa con successo.");
                        }
                        else
                        {
                            Console.WriteLine($"Pubblicazione con codice {codiceDaRimuovere} non trovata.");
                        }
                        break;
                    case "z":

                        ins = false;

                        break;

                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }

                Console.WriteLine("Vuoi vedere la lista delle pubblicazioni ?\n premi a per visualizzare la lista\n premi x per vedere lo stock delle pubblicazioni\n premi z per uscire" 
                    );
                string continua = Console.ReadLine();

                switch (continua.ToLower())
                {
                    case "a":
                        for (int i = 0; i < listaPubblicazioni.Count; i++)
                        {
                            if (listaPubblicazioni[i].GetType() == typeof(Giornale))
                            {
                                Giornale temp = (Giornale)listaPubblicazioni[i];
                                temp.stampaGiornale();
                            }
                            else if (listaPubblicazioni[i].GetType() == typeof(Rivista))
                            {
                                Rivista temp = (Rivista)listaPubblicazioni[i];

                                temp.stampaRivista();
                            }
                        }
                        break;

                    case "z":
                        Console.WriteLine("Arrivederci :)");
                        ins = false;
                        break;

                    case "x":
                                                                            
                        int numGiornali = 0;
                        int numRiviste = 0;

                        foreach (var pubblicazione in listaPubblicazioni)
                        {
                            if (pubblicazione is Giornale)

                                numGiornali++;

                            else if (pubblicazione is Rivista)

                                numRiviste++;
                        }

                        Console.WriteLine($"Numero di giornali: {numGiornali}");

                        Console.WriteLine($"Numero di riviste: {numRiviste}");
                        break;


                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }
            }
        }
    }
}
