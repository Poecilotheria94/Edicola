using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdicolaRml
{
    internal class Rivista: Pubblicazione
    {
 

        public string Titolo { get; set; }

        public string Categoria {get; set; }

        public Rivista(string codice , float prezzo, string titolo, string categoria): base (codice, prezzo) 
        {
        
            Titolo = titolo;
            Categoria = categoria;
        }
        public override void saluta()
        {
            Console.WriteLine($"{Titolo} che fa parte della categoria {Categoria} di prezzo {Prezzo} è stato inserito");
        }

        public void stampaRivista()
        {
            Console.WriteLine("------***Rivista***------");

            Console.WriteLine($"Titolo: {Titolo}");
            Console.WriteLine($"Prezzo: {Prezzo}");
            Console.WriteLine($"Codice : {Codice}");

            Console.WriteLine($"Data e ora: {DateTime.Now}");// da rivedere
            Console.WriteLine("--------------------------");


        }
    }

 
}
