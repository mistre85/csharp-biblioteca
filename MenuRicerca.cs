namespace csharp_biblioteca
{
    internal class MenuRicerca : Menu
    {
        public MenuRicerca(List<Utente> utentiRegistrati, List<Documento> documenti) : base("Ricerca documenti",utentiRegistrati,documenti)
        {
          
        }

        public override void Navigazione()
        {
            Console.WriteLine("Inserisci codice o titolo:");
            string query = Console.ReadLine();

          
            foreach(Documento doc in documenti)
            {
                if(doc.GetIdentifier() == query || doc.Titolo == query)
                {
                    doc.Stampa();
                }
            }
        

        }
    }
}