using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdicolaRml
{
    internal class Pubblicazione
    {
        public string Codice { get; set; }

        public float Prezzo { get; set; }

        public Pubblicazione(string codice, float prezzo)
        {
            Codice = codice;
            Prezzo = prezzo;
        }

        public virtual void saluta()
        {

        }
    }
}
