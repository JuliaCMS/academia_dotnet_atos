using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_10
{
    internal class Animal
    {
        private string _nome;
        private string _especie;
        private int _idade;

        public string Nome  // maneira explicita do get/set
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Especie { get => _especie; set => _especie = value; }

        public int Idade { get => _idade; set => _idade = value; }

        public void EmitirSom (string somAnimal)
        {
            if (_especie == "cachorro")
            {
                Console.WriteLine("auau");
            }
            else if (_especie == "gato")
            {
                Console.WriteLine("miau");
            }
            else if (_especie == "porco")
            {
                Console.WriteLine("oinc oinc");
            }
            else if (_especie == "galo")
            {
                Console.WriteLine("cocoricó");
            }
            else
            {
                Console.WriteLine("Espécie não cadastrada.");
            }
        }

    }
}
