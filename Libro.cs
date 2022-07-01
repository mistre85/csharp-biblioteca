using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Libro : Documento
    {
       
        public string ISBN
        {
            get
            {
                return base.ID;
            }
            set
            {
                base.ID = value;
            }
        }

        public int NumeroPagine { get; private set; }

        public Libro(string iSBN, int numeroPagine, string titolo, string anno, string settore, int scaffale, bool inPrestito, Autore autore) :
            base(iSBN,titolo, anno, settore, scaffale, inPrestito, autore)
        {
            this.NumeroPagine = numeroPagine;
        }

        public override string GetIdentifier()
        {
            //altra cosa;
        }
    }
}
