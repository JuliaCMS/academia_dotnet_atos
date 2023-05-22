using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula22
{
    internal class Pessoa
    {
        private string _nome;
        private string _email;
        private Endereco _end; //atributo do tipo objeto

        /* a instancia do endereço poderia ter sido feita direto dentro de um construtor na classe pessoa
        public Pessoa()
        {
            _end = new Endereco();
        }
        */

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Endereco End
        {
            get {  return end; }
            set { end = value; }
        }
    }
}
