using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_13
{
    internal class Livro
    {
        private string _titulo;
        private Autor _autor;

        public string Titulo { get; set; }
        public Autor Autor { get; set; }

        public Livro(string titulo, Autor autor)
        {
            this.Titulo = titulo;
            this.Autor = autor;
        }

        public Livro()
        {

        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Título do livro: " + Titulo);
            Console.WriteLine("Autor: " + Autor.Nome);
            Console.WriteLine("Nacionalidade do Autor: " + Autor.Nacionalidade);
        }
    }
}
