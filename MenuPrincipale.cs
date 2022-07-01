using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class MenuPrincipale : Menu
    {
        public MenuPrincipale(List<Utente> utentiRegistrati, List<Documento> documenti) : base("Biblioteca online", utentiRegistrati, documenti)
        {
            this.voci.Add(new MenuRegistrati(utentiRegistrati,documenti));
            this.voci.Add(new MenuLogin(utentiRegistrati,documenti));
            this.voci.Add(new MenuEsci(utentiRegistrati,documenti));
        }
    }
}
