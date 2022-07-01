using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Menu
    {
        string Titolo { get; set; }

        protected List<Menu> voci;

        protected List<Utente> utentiRegistrati;

        protected List<Documento> documenti;

        public Menu(string titolo,List<Utente> utentiRegistrati,List<Documento> documenti)
        {
            this.Titolo = titolo;
            voci = new List<Menu>();

            this.utentiRegistrati = utentiRegistrati;
            this.documenti = documenti;
       
        }
        public virtual void Esegui()
        {
            Console.Clear();
            Console.Write("Da implementare");
        }

        public virtual void Navigazione()
        {
            Console.WriteLine(this.Titolo);

            
            for (int i = 0; i < voci.Count(); i++)
            {
                Console.WriteLine((i + 1) + ". " + voci[i].Titolo);
            }
           
            Console.WriteLine("Cosa vuoi fare?: ");
            int menuIndex = int.Parse(Console.ReadLine());

            //aggiusto la scelta human readable rispetto all'indice dell'utente
            menuIndex = menuIndex - 1;

            if (menuIndex > voci.Count())
            {
                Console.WriteLine("La voce di menu selezionata non esite!");
                this.Navigazione();
            }
            else {

                voci[menuIndex].Navigazione();
            }

            
        }

        

    }
}
