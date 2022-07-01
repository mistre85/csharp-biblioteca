using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class DVD : Documento
    {
        public string SN
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

        public int Durata { get; private set; }

        public DVD(string sN, int durata, string titolo, string anno, string settore, int scaffale, bool inPrestito, Autore autore) :
           base(sN, titolo, anno, settore, scaffale, inPrestito, autore)
        {
            this.Durata = durata;
        }
    }
}
