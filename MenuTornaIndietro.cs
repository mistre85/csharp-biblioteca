using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class MenuIndietro : Menu
    {
        public MenuIndietro( List<Utente> utentiRegistrati, List<Documento> documenti) : base("Torna indietro", utentiRegistrati, documenti)
        {

        }
    }
}
