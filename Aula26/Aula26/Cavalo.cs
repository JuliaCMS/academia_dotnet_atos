﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula26
{
    internal class Cavalo : Animal
    {
        public string Raca { get; set; }
        public Cavalo(string nome, int idade, string raca) : base(nome, idade)
        {
            Raca = raca;
        }

        public override void emitirSom()
        {
            Console.WriteLine("O " + this.Nome + " está relinchando!");
        }

    }
}
