using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aula21
{
    internal class Pessoa
    {
        /*1 - Criar uma classe chamada Pessoa com 2 construtores, um que receba o nome e a idade da pessoa e
                outro recebendo apenas a idade.Solicite ao usuário qual dos construtores ele gostaria de utilizar
                na instanciação da classe.Além de receber parâmetros, os construtores imprimem na tela o conteúdo
                dos parâmetros recebidos
         */

        private string nome;
        private int idade;
        public double salario;
        /*public Pessoa(string nome, int idade)
          {
              this.nome = nome;
              this.idade = idade;
              Console.WriteLine("Nome: "+nome+" Idade: "+idade);
          }
          public Pessoa(int idade)
          {
              this.idade = idade;
              Console.WriteLine("Idade: " + idade);
          }*/



        /* Maneira clássica do uso de get em outras linguagens de programação:
         
         public string getNome
        {
                return this.nome;
        }
        
         */


        public Pessoa()
        {
            //this.nome = "Astolfo";
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
