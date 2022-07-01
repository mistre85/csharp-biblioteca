using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {

        protected string ID { get; set; }
        public string Titolo { get; private set; }
        public string Anno { get; private set; }
        public string Settore { get; private set; }
        public int Scaffale { get; private set; }
        public bool InPrestito { get; private set; }
        public Autore Autore { get; private set; }


        public Documento(string iD, string titolo, string anno, string settore, int scaffale, bool inPrestito, Autore autore)
        {
            ID = iD;
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Scaffale = scaffale;
            InPrestito = inPrestito;
            Autore = autore;
        }

        public virtual string GetIdentifier()
        {
            return this.ID;
        }

        public void Stampa()
        {
            Console.WriteLine("id: " + this.ID);
            Console.WriteLine("Titolo: " + this.Titolo);
             
        }
    }
}

