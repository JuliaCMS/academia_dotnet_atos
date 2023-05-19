using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20
{
    internal class Paciente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Email { get; set; }

        public Paciente() { } 
        public Paciente(string nome, string cpf, DateOnly dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public Paciente(string nome, string cpf, DateOnly dataNascimento, string email)
        {
            //vai reaproveitar os atributos do construtor de cima
            Email = email; 
        }

        public int Idade ()
        {
            return DateTime.Now.Year - DataNascimento.Year; // (ano atual menos ano de nascimento)
        }

    }
}
