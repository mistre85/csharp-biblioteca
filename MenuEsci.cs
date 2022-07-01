using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class MenuEsci : Menu
    {
        public MenuEsci(List<Utente> utentiRegistrati, List<Documento> documenti) : base("Esci", utentiRegistrati, documenti)
        {
        }

        public override void Navigazione()
        {
            return;
        }

    }
}
