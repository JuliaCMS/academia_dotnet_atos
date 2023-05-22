using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_13
{
    internal class Autor
    {
        private string _nome;
        private string _nacionalidade;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Nacionalidade
        {
            get { return _nacionalidade; }
            set { _nacionalidade = value; }
        }

        public Autor()
        {

        }

        public Autor(string nome, string nacionalidade)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
        }
    }
}
