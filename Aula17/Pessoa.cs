using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17
{
    internal class Pessoa
    {
        //------------- CONTEÚDO DA AULA ---------------------
        //public string nome; // isso é um atributo/propriedade
        //public int idade;

        //// atalho para o construtor: ctor

        //public Pessoa()
        //{

        //}
        //public Pessoa(string nome, int idade)
        //{
        //    this.nome = nome;
        //    this.idade = idade;
        //}

        //public void exibeDados() // isso é um método
        //{
        //    Console.WriteLine("Nome: " + this.nome); // this serve para referenciar o atributo dentro da classe
        //    Console.WriteLine("Idade: " + this.idade);

        // ----------- FIM DO CONTEÚDO DA AULA -------------------



        //------------------ EXERCÍCIO 3 ------------------
        /* Criar uma classe chamada Pessoa com 2 construtores, um que receba o nome e a idade da pessoa e outro recebendo apenas a idade. Solicite ao 
         * usuário qual dos construtores ele gostaria de utilizar na instanciação da classe. Além de receber parâmetros, os construtores imprimem na tela o 
         * conteúdo dos parâmetros recebidos. */

        public string nome;
        public int idade;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nome: " + nome + "\nIdade: " + idade);
            Console.WriteLine("-----------------------");
        }

        public Pessoa(int idade)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("-----------------------");
        }
    }
}
