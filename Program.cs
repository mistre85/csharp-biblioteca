//una serie di istanze per "popolare" il nostro "fake db"
// 2 o 3 utenti -> registrati
// 2 o 3 libri --> tutti disponibili
// Gli utenti si possono registrare specificando i dati ...


using csharp_biblioteca;

//database fake
List<Utente> utentiRegistrati = new List<Utente>();
List<Documento> documenti = new List<Documento>();

utentiRegistrati.Add(new Utente("Paolo", "Mistretta", "paolo@mistre.it", "123456",true));
utentiRegistrati.Add(new Utente("Pinco", "Pallo", "pinco@pallo.it", "123456", true));
utentiRegistrati.Add(new Utente("Zio", "Paperone", "zio@paperone.it", "123456", true));

documenti.Add(new Libro("8863862192", 237, "il potere di adesso", "2013","spirituali",10,false,new Autore("Echkart","Tolle")));
documenti.Add(new Libro("8863862193", 237, "il potere di ieri", "2012", "spirituale", 10, false, new Autore("Echkart", "Tolle")));
documenti.Add(new Libro("8863862194", 237, "il potere di domani", "2012", "spirituale", 10, false, new Autore("Echkart", "Tolle")));
documenti.Add(new DVD("A39919019",180,"Matrix","1999","verità",1,false,new Autore("Sofia","Stewart")));
documenti.Add(new DVD("A39919020", 180, "Matrix 2", "1999", "guerra", 1, false, new Autore("Sofia", "Stewart")));
documenti.Add(new DVD("A39919011", 180, "Matrix 3", "1999", "guerra", 1, false, new Autore("Sofia", "Stewart")));

Menu menu = new MenuPrincipale(utentiRegistrati,documenti);

menu.Navigazione();

// Biblioteca online
// 1. registrati
// 2. login

//login 
// email: ..
// passowrd: ..

// Biblioteca online
// 1. Cerca libri
// 2. Cerca dvd

// Registrazione
// Scrivmi il nome: 
// scrivimi il cognome.. etc
// scrivi la passowrd: 

// Menu libro (titolo)
// 1. visualizza dettagli libro
// 2. richiedi prestito
// 3. restitutisci


// tutti i menu hanno esci o torna indietro
