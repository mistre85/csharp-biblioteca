using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Autore
    {
        public string Nome { get; private set; }

        public string Cognome { get; private set; }

        public Autore(string nome, string cognome)
        {
            this.Nome = nome;   
            this.Cognome = cognome; 
        }
    }
}
