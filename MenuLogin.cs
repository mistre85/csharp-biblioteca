namespace csharp_biblioteca
{
    internal class MenuLogin : Menu
    {

        public MenuLogin(List<Utente> utentiRegistrati, List<Documento> documenti) : base("Login", utentiRegistrati, documenti)
        {
            this.voci.Add(new MenuRicerca(utentiRegistrati, documenti));
        }

        public override void Navigazione()
        {
            Console.Clear();
            Console.WriteLine("Login");

            Console.Write("Inserisci email:");
            string email = Console.ReadLine();
            Console.Write("Inserisci password:");
            string password = Console.ReadLine();

            bool utenteTrovato = false;

            foreach(Utente utente in utentiRegistrati)
            {
                if(utente.Email == email && utente.Password == password)
                {
                    utenteTrovato = true;
                    break;
                }
            }

            if (utenteTrovato)
            {
                Console.Clear();
                Console.WriteLine("Accesso consentito");
                Thread.Sleep(3000);
                base.Navigazione();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Accesso negato");
                Thread.Sleep(3000);
               
            }
        }

    }
}