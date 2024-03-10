using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdicolaRml
{
    internal class Giornale: Pubblicazione
    {
      

        public string Redazione { get; set;}

        public bool HasInserito {get; set;}

        public Giornale(string codice , float prezzo, string redazione, bool hasInserito): base(codice, prezzo)
        {
   
            Redazione = redazione;
            HasInserito = hasInserito;
        }

        public override void saluta()
        { 
            Console.WriteLine($"Il giornale con codice {Codice} di prezzo {Prezzo} scritto da {Redazione} è stato inserito");
        }

        public void stampaGiornale()
        {
            Console.WriteLine("------***Giornale***------");
            
            Console.WriteLine($"Codice : {Codice}");
            Console.WriteLine( $"Redazione: {Redazione}");
            Console.WriteLine($"Prezzo: { Prezzo}");

            Console.WriteLine($"Data e ora: {DateTime.Now}"); // da rivedere
            Console.WriteLine(  "----------------------");
        }
    }
}
