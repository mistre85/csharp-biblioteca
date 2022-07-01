namespace csharp_biblioteca
{
    internal class MenuRegistrati : Menu
    {


        public MenuRegistrati( List<Utente> utentiRegistrati, List<Documento> documenti) : base("Registrazione", utentiRegistrati, documenti)
        {
           
        }
    }
}