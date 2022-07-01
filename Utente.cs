using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente
    {
        public string Cognome { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Telefono { get; private set; }

        public string Password { get; private set; }

        public bool Registrato { get; private set; }

        public Utente(string nome, string cognome,string email,string password = null,bool registrato = false)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Email = email;
            this.Registrato = false;
            this.Password = password;
            this.Registrato = registrato;
        }


    }

    
}
