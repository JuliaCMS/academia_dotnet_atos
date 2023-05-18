using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17
{
    internal class Aluno
    {
        public string nome;
        public string matricula;
        public DateTime dataNascimento;
        public int anoIngresso;

        public Aluno(string nome, string matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Nome do aluno: " + this.nome + " \nMatrícula: " + this.matricula);
            Console.WriteLine("---------------------------------");
        }

        public Aluno(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Data de nascimento do aluno: " + this.dataNascimento);
            Console.WriteLine("---------------------------------");
        }

        public Aluno(string nome, DateTime dataNascimento, int anoIngresso)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.anoIngresso = anoIngresso;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Nome do aluno: " + this.nome + "\nData de nascimento: " + this.dataNascimento + "\nAno de ingresso na faculdade: " + this.anoIngresso);
            Console.WriteLine("---------------------------------");
        }
    }
}
